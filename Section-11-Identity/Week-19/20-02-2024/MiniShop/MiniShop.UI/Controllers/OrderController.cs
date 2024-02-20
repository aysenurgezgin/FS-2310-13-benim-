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
        private readonly IShoppingCartItemService _shoppingCartItemService;
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        //Login olmuş kulanıcının geçmiş siparişlerini gösterecek.
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult>Checkout()
        {
            var userId = _userManager.GetUserId(User);
            var user
            OrderViewModel orderViewModel = new OrderViewModel
            {

            };
            return View();
        }
    }
}
