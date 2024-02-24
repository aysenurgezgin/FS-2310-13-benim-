using Microsoft.AspNetCore.Mvc.Rendering;
using MiniShop.Shared.ViewModels;

namespace MiniShop.UI.Areas.Admin.Models
{
    public class OrderFilterViewModel
    {
        public List<AdminOrderViewModel> Products { get;  set; }
        public List<SelectListItem> ProductListItems { get;  set; }
    }
}
