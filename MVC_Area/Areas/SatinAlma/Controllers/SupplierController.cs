using Microsoft.AspNetCore.Mvc;
using MVC_Area.Repositories.Abstracts;
using MVC_Area.Repositories.Concretes;

namespace MVC_Area.Areas.SatinAlma.Controllers
{
    [Area("SatinAlma")]
    public class SupplierController : Controller
    {
        private readonly ISupplierRepository _suppleierRepository;


        public SupplierController(ISupplierRepository supplierRepository)
        {
            _suppleierRepository = supplierRepository;
        }
        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}
