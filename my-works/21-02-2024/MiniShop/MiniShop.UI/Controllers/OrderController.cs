using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;

namespace MiniShop.UI.Controllers
{
    public class OrderController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IShoppingCartService _shoppingCartManager;
        private readonly IOrderService _orderManager;

        public OrderController(UserManager<User> userManager, IShoppingCartService shoppingCartManager, IOrderService orderManager)
        {
            _userManager = userManager;
            _shoppingCartManager = shoppingCartManager;
            _orderManager = orderManager;
        }

        //Login olmuş kullanıcının geçmiş siparişlerini gösterecek
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            var shoppingCart = await _shoppingCartManager.GetShoppingCartByUserIdAsync(userId);
            OrderViewModel orderViewModel = new OrderViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                City = user.City,
                Email   = user.Email,
                PhoneNumber = user.PhoneNumber,
                Note="Lütfen hızlı gelsin.",
                CardNumber= "4987490000000002",
                CardName="Sezen Aksu",
                ExpirationMonth="8",
                ExpirationYear="2028",
                Cvc="343",
                ShoppingCart=shoppingCart.Data
            };
            //orderViewModel.ShoppingCart = shoppingCart.Data;
            return View(orderViewModel);
        }
        public async Task<IActionResult> Checkout(OrderViewModel orderViewModel)
        {
            return Redirect("~/");
        }

    }
}
