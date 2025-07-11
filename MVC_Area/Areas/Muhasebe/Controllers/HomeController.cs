using Microsoft.AspNetCore.Mvc;
using MVC_Area.Repositories.Abstracts;
using MVC_Area.Repositories.Concretes;

namespace MVC_Area.Areas.Muhasebe.Controllers
{
    [Area("Muhasebe")]
    public class HomeController : Controller
    {
        private readonly IOrderRepository _ordersRepository;
        private readonly IOrdersDetailsRepository _ordersDetailsRepository;
       


        public HomeController(IOrderRepository ordersRepository, IOrdersDetailsRepository ordersDetailsRepository)
        {
            _ordersRepository = ordersRepository;
            _ordersDetailsRepository = ordersDetailsRepository;
          

        }



        public async Task<IActionResult> Index()
        {

            //ViewBag Order Count
            ViewBag.OrderCount = await _ordersRepository.GetOrderCountAsync();

            //ViewBag OrdersDetails Count
            ViewBag.OrdersDetailsCount = await _ordersDetailsRepository. GetOrdersDetailsCountAsync();


            ////ViewBag SalesByCategory Count
            //ViewBag.SupplierCount = await _suppleierRepository.GetSupplierCountAsync();




            return View();
        }
    }
}
