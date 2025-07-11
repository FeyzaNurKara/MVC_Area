using Microsoft.AspNetCore.Mvc;
using MVC_Area.Repositories.Abstracts;
using MVC_Area.Repositories.Concretes;

namespace MVC_Area.Areas.Muhasebe.Controllers
{
    public class SaleByCategoryController : Controller
    {
        private readonly ISaleByCategoryRepository _saleByCategoryRepository;

        public SaleByCategoryController(ISaleByCategoryRepository saleByCategoryRepository)
        {
            _saleByCategoryRepository = saleByCategoryRepository;
        }



        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}
