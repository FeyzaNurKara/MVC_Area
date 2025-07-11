using Microsoft.AspNetCore.Mvc;
using MVC_Area.Repositories.Abstracts;

namespace MVC_Area.Areas.Muhasebe.Controllers
{
    public class OrdersDetailsController: Controller
    {
        private readonly IOrdersDetailsRepository _ordersDetailsRepository;



        public OrdersDetailsController(IOrdersDetailsRepository ordersDetailsRepository)
        {
            _ordersDetailsRepository = ordersDetailsRepository;
        }
        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}
