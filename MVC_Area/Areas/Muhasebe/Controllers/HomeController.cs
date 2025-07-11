using Microsoft.AspNetCore.Mvc;
using MVC_Area.Repositories.Abstracts;
using MVC_Area.Repositories.Concretes;

namespace MVC_Area.Areas.Muhasebe.Controllers
{
    [Area("Muhasebe")]
    public class HomeController : Controller
    {
        private readonly IOrderRepository _ordersRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
       


        public HomeController(IOrderRepository ordersRepository, IOrderDetailRepository orderDetailRepository)
        {
            _ordersRepository = ordersRepository;
            _orderDetailRepository= orderDetailRepository; 
          

        }



        public async Task<IActionResult> Index()
        {

            //ViewBag Order Count
            ViewBag.OrderCount = await _ordersRepository.GetOrderCountAsync();

            //ViewBag OrdersDetails Count
            ViewBag.OrderDetailCount=await _orderDetailRepository.GetOrdersDetailsCountAsync();



            ////ViewBag SalesByCategory Count
            //ViewBag.SupplierCount = await _suppleierRepository.GetSupplierCountAsync();




            return View();
        }
    }
}
