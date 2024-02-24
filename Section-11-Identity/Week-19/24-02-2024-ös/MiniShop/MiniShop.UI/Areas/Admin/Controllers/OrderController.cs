using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;

namespace MiniShop.UI.Areas.Admin.Controllers
{
    [Authorize(Roles = "SuperAdmin, Admin")]
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderManager;

        public OrderController(IOrderService orderManager)
        {
            _orderManager = orderManager;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _orderManager.GetOrdersAsync();
            return View(orders);
        }
    }
}
