using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels.IdentityModels;

namespace MiniShop.UI.Areas.Admin.Controllers
{
    [Authorize(Roles ="SuperAdmin")]
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public UserController(RoleManager<Role> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        //public async Task<IActionResult>Index()
        //{
        //    var users=await _userManager.Users.ToListAsync();
        //    return View(users);
        //}
        [HttpGet]
        public async Task<IActionResult> Index() => View(await _userManager.Users.ToListAsync());//*tek return varsa eğer

        public async Task<IActionResult> AssignRoles(string id)
        {
            //Id si gönderilen , rol ataması yapılacak user'ı buluyoruz.
            var user= await _userManager.FindByIdAsync(id);
            //Bulduğumuz user'ın var olan rollerini alıyoruz.
            var userRoles = await _userManager.GetRolesAsync(user);
            

            //İlgili user'ın rollerini de içercek şekilde rol listesini oluşturuyoruz.
            var roles= await _roleManager.Roles.Select(r=> new AssignRoleViewModel
           {     
            RoleId=r.Id,
            RoleName=r.Name,
            IsAssigned=userRoles.Any(x=>x==r.Name)
           }).ToListAsync();
            //View'in ihtiyacı olan userId ve rol listesini içere modeli oluşturuyoruz.
            var userRolesViewModel = new UserRolesViewModel
            {
                Id = user.Id,
                Name=$"{user.FirstName}{user.LastName}",
                UserName=user.UserName,
                Roles = roles
            };
            return View(userRolesViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> AssignRoles(UserRolesViewModel userRolesViewModel)
        {
            if(ModelState.IsValid) 
            {
                var user =await _userManager.FindByIdAsync(userRolesViewModel.Id);
                foreach(var role in userRolesViewModel.Roles)
                {
                    if (role.IsAssigned)//*user' a rol eklemek
                    {
                        await _userManager.AddToRoleAsync(user, role.RoleName);
                    }
                    else
                    {
                        await _userManager.RemoveFromRolesAsync(user, role.RoleName);//hocanın repo!!
                    }
                }
                return RedirectToAction("Index");
            }
            return View(userRolesViewModel);
        }
    }
}
