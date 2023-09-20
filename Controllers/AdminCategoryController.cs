using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
using WebApplication1.Services.Interfaces;
using WebApplication1.ViewModels.Categories;

namespace WebApplication1.Controllers
{
    public class AdminCategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public AdminCategoryController(ICategoryService context)
        {
            _categoryService = context;
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
        public IActionResult Add(CategoryDropdownViewModel model)
        {
            _categoryService.Add(model);
            return View();
        }
    }
}
