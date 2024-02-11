using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.Areas.Admin.Controllers
{

    [Authorize(Roles = "SuperAdmin")]
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public RoleController(RoleManager<Role> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}
        public async Task<IActionResult> Index() => View(await _roleManager.Roles.ToListAsync());//*tek return varsa eğer
    }
}
