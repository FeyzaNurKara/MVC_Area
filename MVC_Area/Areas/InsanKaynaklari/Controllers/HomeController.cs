using Microsoft.AspNetCore.Mvc;
using MVC_Area.Repositories.Abstracts;

namespace MVC_Area.Areas.InsanKaynaklari.Controllers
{
    [Area("InsanKaynaklari")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;





        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;


        }



        public async Task<IActionResult> Index()
        {

            //ViewBag employee Count
            ViewBag.EmployeeCount = await _employeeRepository.GetEmployeeCountAsync();






            return View();
        }
    }

}
