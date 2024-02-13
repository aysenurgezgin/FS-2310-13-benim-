using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.ViewModels
{
    public class ShoppingCartViewModel
    {
        public int ShoppingCartId { get; set; }
        public List<ShoppingCartItemViewModel> Items { get; set; }
        public double TotalPrice()
        {
            return Items
        }
    }
}
