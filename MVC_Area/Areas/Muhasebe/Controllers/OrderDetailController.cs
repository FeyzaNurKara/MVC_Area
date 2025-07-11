using Microsoft.AspNetCore.Mvc;
using MVC_Area.Repositories.Abstracts;

namespace MVC_Area.Areas.Muhasebe.Controllers
{
    public class OrderDetailController: Controller
    {
        private readonly IOrderDetailRepository _orderDetailRepository;



        public OrderDetailController(IOrderDetailRepository orderDetailsRepository)
        {
            _orderDetailRepository = orderDetailsRepository;
        }
        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}
