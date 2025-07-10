using Microsoft.AspNetCore.Mvc;
using MVC_Area.Repositories.Abstracts;

namespace MVC_Area.Areas.SatinAlma.Controllers
{
    [Area("SatinAlma")]
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public HomeController(IProductRepository productRepository,ICategoryRepository categoriesRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoriesRepository;
        }

       

        public async Task<IActionResult> Index()
        {

            //ViewBag Product Count
            ViewBag.ProductCount=await _productRepository.GetProductCountAsync();

            //ViewBag Category Count
            ViewBag.CAtegoryCount = await _categoryRepository.GetCategoryCountAsync();


            //ViewBag Supplier Count

            //ViewBag CriticalStockCount

            return View();
        }
    }
}
