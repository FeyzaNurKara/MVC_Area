using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Area.Repositories.Abstracts;

namespace MVC_Area.Areas.SatinAlma.Controllers
{
    [Area("SatinAlma")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IActionResult> Index()
        {
          
            return View();
        }
    }
}