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
        private readonly ISaleByCategoryRepository _saleByCategoryRepository;

       


        public HomeController(IOrderRepository ordersRepository, IOrderDetailRepository orderDetailRepository, ISaleByCategoryRepository saleByCategoryRepository)
        {
            _ordersRepository = ordersRepository;
            _orderDetailRepository= orderDetailRepository;
            _saleByCategoryRepository=saleByCategoryRepository;


        }



        public async Task<IActionResult> Index()
        {

            //ViewBag Order Count
            ViewBag.OrderCount = await _ordersRepository.GetOrderCountAsync();

            //ViewBag OrdersDetails Count
            ViewBag.OrderDetailCount=await _orderDetailRepository.GetOrdersDetailsCountAsync();



            ////ViewBag SaleByCategory Count
            ViewBag.SaleByCategoryCount=await _saleByCategoryRepository.GetSaleByCategoryCountAsync();





            return View();
        }
    }
}
