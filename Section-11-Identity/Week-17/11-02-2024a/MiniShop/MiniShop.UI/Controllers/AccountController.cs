using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels.IdentityModels;

namespace MiniShop.UI.Controllers
{


    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;//*LoginLogout işlemlerini 

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            //*gelen verilerin kurallara uygun olup olmadığını kontrol ediyoruz;
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email,
                    FirstName = registerViewModel.FirsName,
                    LastName = registerViewModel.LastName
                };

                var result=await _userManager.CreateAsync(user,registerViewModel.Password);//*Hash leme işlmini virgülden sonrası hallediyor.
                if (result.Succeeded) 
                {
                    //return RedirectToAction("Index","Home");
                    return Redirect("~/");
                }
            }
            return View(registerViewModel);
        }

        [HttpGet]
        public IActionResult Login()//*sayfayı açacak
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)//*bilgileri buraya alacak.
        {
            if(!ModelState.IsValid) 
            {
                return View(loginViewModel);
            }
            User user= await _userManager.FindByNameAsync(loginViewModel.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı bulunamadı.");
                return View(loginViewModel);
            }
            var result =await _signInManager.PasswordSignInAsync(user,loginViewModel.Password,false,false);
            if(!result.Succeeded)
            {
                ModelState.AddModelError("", "Şifre hatalı.");
                return View(loginViewModel);

            }



            return RedirectToAction("Index","Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();//Login out onları tutar
            return Redirect("~/");
        }
    }
}
