using Microsoft.AspNetCore.Mvc;
using MVC_Area.Repositories.Abstracts;

namespace MVC_Area.Areas.SatinAlma.Controllers
{
    [Area("SatinAlma")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoriesRepository;
       

        public CategoryController(ICategoryRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }
        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}
