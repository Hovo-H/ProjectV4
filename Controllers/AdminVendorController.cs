using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
using WebApplication1.Services.Interfaces;
using WebApplication1.ViewModels.Categories;
using WebApplication1.ViewModels.Vendors;

namespace WebApplication1.Controllers
{
    public class AdminVendorController : Controller
    {
        private readonly IVendorService _vendorservice;
        public AdminVendorController(IVendorService context)
        {
            _vendorservice = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(VendorDropdownViewModel model)
        {
            _vendorservice.Add(model);
            return View();
        }
    }
}
