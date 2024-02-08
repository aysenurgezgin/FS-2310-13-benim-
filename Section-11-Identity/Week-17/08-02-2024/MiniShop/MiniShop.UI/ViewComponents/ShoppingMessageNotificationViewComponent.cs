using Microsoft.AspNetCore.Mvc;
namespace MiniShop.UI.ViewComponents
{
    public class ShoppingMessageNotificationViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult>InvokeAsync()
        {
            return View();
        }
    }
}
