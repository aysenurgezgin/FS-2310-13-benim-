using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;
using MiniShop.Shared.ViewModels.IdentityModels;
using MiniShop.UI.EmailServices.Abstract;

namespace MiniShop.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IOrderService _orderManager;
        private readonly IEmailSender _emailSender;
        private readonly IShoppingCartService _shoppingCartManager;
        //*Bununların ismi servis ve manager olmak zorun da değil yaklaşımı uyguluyoruz burada sadece hepsine servis te denilebilir hatta sınıflara da öyle isim verilebilir sadece interface olanlara I demiş oluruz
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IOrderService orderManager, IEmailSender emailSender, IShoppingCartService shoppingCartManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _orderManager = orderManager;
            _emailSender = emailSender;//*Bunu eklemeyi unutma yoksa null kalır.
            _shoppingCartManager = shoppingCartManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if(ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email,
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName
                };

                var result = await _userManager.CreateAsync(user,registerViewModel.Password);
                if (result.Succeeded)
                {
                    //Mail gönderme işlemi başlıyor.
                    //Token oluşturma
                  var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);//*Token oluştu  bu tokenı içine gömebileceğim bir maili oluşturmaya hazırım;Tıklayınca nereye gitsin (backUrl işte)
                    //*(1.'si=actin ismi 2.hangi Controller içinde olması 3.sünde anonim bir nesne oluşturucam(tip vermezsem anonim nesne)içine userId ve token vererek şu şekilde bir link olş=site ismi/account/ConfirmEmailden sonra?gelen parametreolaak=UserId=userId(karışık hani)&işaretiyle birliteüretilen  tokenCode gelicek:Bu benzersizliğide ardırıyor.Url üz 2 bilgiyi gönd uluyorum
                    var backUrl = Url.Action("ConfirmEmail", "Account", new
                    {
                        userId=user.Id,
                        token=tokenCode
                    });
                    //*Artık Mail gönd için gerkli bilg sahibim,mail gönd işlemleri;EmailSener'ımızı buraya dahil etmemiz gerekiyordu
                    await _emailSender.SendEmailAsync(user.Email,
                        "MiniShopApp Üyelik Oanyı",
                   //*Şimdi html kodlarımı yazıyorum;burda değişken kullanacağımız için başına dolar işareti koyduk.href kısmını url için olan kısmı da ekledik
                   $"<p>MiniShopApp uygulamasına üyeliğinizi onaylamak için aşağıdaki linke tıklayınız.</p><a href='https://localhost:59079{backUrl}'>Onay Linki</a>"
                      );
                    return Redirect("~/");
                }
            }
            return View(registerViewModel);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl=null)
        {
            if (returnUrl != null)
            {
                TempData["ReturnUrl"] = returnUrl;
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(loginViewModel);
            }
            User user = await _userManager.FindByNameAsync(loginViewModel.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı bulunamadı");
                return View(loginViewModel);
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
            if(!result.Succeeded)
            {
                ModelState.AddModelError("", "Şifre hatalı");
                return View(loginViewModel);
            }
            var returnUrl = TempData["ReturnUrl"]?.ToString();
            if(!String.IsNullOrEmpty(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData["ReturnUrl"] = null;
            return Redirect("~/");
        }
        
        public IActionResult AccessDenied()
        {
            return View();
        }
    
        public async Task<IActionResult> Profile()
        {
            var userId = _userManager.GetUserId(User);
            var orders = await _orderManager.GetOrdersAsync(userId);
            var user = await _userManager.FindByIdAsync(userId);
                
            UserProfileViewModel userProfileViewModel = new UserProfileViewModel
            {
                User = new UserViewModel
                {
                    Id= userId,
                    FirstName = user.FirstName,
                    LastName= user.LastName,
                    UserName = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Address = user.Address,
                    City = user.City,
                    Gender = user.Gender,
                    DateOfBirth = user.DateOfBirth
                },
                Orders = orders
            };
            return View(userProfileViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(UserProfileViewModel userProfileViewModel)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            if (ModelState.IsValid)
            {
                user.FirstName = userProfileViewModel.User.FirstName;
                user.LastName= userProfileViewModel.User.LastName;
                user.Email=userProfileViewModel.User.Email;
                user.City = userProfileViewModel.User.City;
                user.Address = userProfileViewModel.User.Address;
                user.PhoneNumber = userProfileViewModel.User.PhoneNumber;
                user.DateOfBirth=userProfileViewModel.User.DateOfBirth;
                user.Gender=userProfileViewModel.User.Gender;
                user.UserName=userProfileViewModel.User.UserName;
                
                var result = await _userManager.UpdateAsync(user);
                if(result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);
                    await _signInManager.SignOutAsync();
                    await _signInManager.SignInAsync(user, false);
                    return Redirect("~/");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            userProfileViewModel.Orders = await _orderManager.GetOrdersAsync(userId);
            return View(userProfileViewModel);
        }

        public async Task<IActionResult> ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
                var isVerified = await _userManager.CheckPasswordAsync(user, changePasswordViewModel.OldPassword);
                if (isVerified)
                {
                    var result = await _userManager.ChangePasswordAsync(user,changePasswordViewModel.OldPassword, changePasswordViewModel.NewPassword);
                    if (result.Succeeded)
                    {
                        var updateSecurityStampResult = await _userManager.UpdateSecurityStampAsync(user);
                        await _signInManager.SignOutAsync();
                        await _signInManager.PasswordSignInAsync(user, changePasswordViewModel.NewPassword, false, false);
                        return RedirectToAction("Profile");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(changePasswordViewModel);
                }
                ModelState.AddModelError("", "Geçerli şifreniz hatalıdır!");
            }
            return View(changePasswordViewModel);
        }
        //*ConfirmEmaili oluşturma sebebim;birisine mail gönd .onay için o kişi onu gönd. mail içinde link olucak,kişi o linke tıklayınca bu tetiklenecek,o maili de yukarıda Register'da oluştumuştum orada iki bilgi gönderiyot?=ConfirmEmail içerisine bu ikisini karşılamam gerekiyor;()içine yazıyorum
        public async Task<IActionResult> ConfirmEmail(string userId,string token)//*userId ve token'ı bilerek o şekilde yazdım;Register dan ben göndermiştim zaten o linki oluştururken(karşıladığım parametrenin adı da aynı olur du demek istiyorum yani)
          //*aldığım bu bilgileri?=kontrol edicez;ama ondan önce if yapısı olş.
        {
            if (userId == null || token == null)
            {
                ModelState.AddModelError("", "Bilgilerde sorun var,yönetici ile görüşünüz.");
                return View();
            }
            var user= await _userManager.FindByIdAsync(userId);
            if (user == null)
                //*Yukarıda userId gelmiş ama ben de bu userId ile kayıtlı bir user yok
            {
                ModelState.AddModelError("", "Kullanıcı bilgilerinize ulaşılamadı.");
                return View();
            }
            //*Her şey yolundaysa bu mail'i onayla diyoruz;bir değişkenin içine alcak şekilde methodumuzu kullanalım;(await)asenkron bir yapıda _userManger'ın içinde ConfirmEmailAsync methodumuz var=İlgili Tokenı ve user bilgisini kullanıcak,userın mesela confirmemail kolonunu true ya çevirecekörn bu methot(mantıken bu işleri yapar bu methot)
            var result = await _userManager.ConfirmEmailAsync(user, token);
            //*result succeeded ise bu mail onaylanmıştır.
            if (result.Succeeded)
            {
                //Bu kişi onaylı bir kişi olduğuna göre,bir shoppingcart oluşturuyoruz.aamanager üzerinde Initialize.. vardı kim için oluturulacaksa onun Id'sini veriyorduk.
                await _shoppingCartManager.InitializeShoppingCartAsync(userId);
                //*Başarılı mesajını zaten oluşturacağımz ConfirmEmail'e ilgili View oluşrucaz zaten yine o View e gönderip başarılı mesajını onda gönderilebilir;modeli buraya ()ekliyoruz
                return View("ConfirmEmail","Hesabınız başarıyla onaylanmıştır.Hoş Geldiniz.");
            }

            return View();
        }
    }
}
