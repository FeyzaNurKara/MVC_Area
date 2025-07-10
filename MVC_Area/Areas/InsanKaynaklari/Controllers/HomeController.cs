using Microsoft.AspNetCore.Mvc;

namespace MVC_Area.Areas.InsanKaynaklari.Controllers
{
    [Area("InsanKaynaklari")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
