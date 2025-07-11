using Microsoft.AspNetCore.Mvc;
using MVC_Area.Repositories.Abstracts;
using MVC_Area.Repositories.Concretes;

namespace MVC_Area.Areas.Muhasebe.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _ordersRepository;


        public OrderController(IOrderRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }
        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}
