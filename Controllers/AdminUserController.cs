using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Entities;
using WebApplication1.Services;
using WebApplication1.Services.Interfaces;
using WebApplication1.ViewModels.Users;

namespace WebApplication1.Controllers
{
    public class AdminUserController : Controller
    {
        private readonly IUserService _userService;
        public AdminUserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            _userService.Delete(Id);
            return RedirectToAction("UserList");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UserList()
        {
            var model = _userService.GetAllUsers();
            return View(model);
        }
        [HttpPost]
        public IActionResult UserList(UserViewModel user)
        {
            var model = _userService.GetAllUsers();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddUpdateUser(int? Id)
        {
            UserViewModel model = Id.HasValue ? _userService.GetById(Id.Value) : new UserViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddUpdateUser(UserViewModel model)
        {
            if (model.Id > 0)
            {
                _userService.Update(model);
            }
            else
            {
                _userService.Add(model);
            }
            return View();
        }
    }
}
