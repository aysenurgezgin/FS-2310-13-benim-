using MiniShop.Business.Abstract;
using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{
    public class ShoppingCartManager : IShoppingCartService
    {
        public Task<Response<NoContent>> AddToCartAsync(string userId, string shoppingCartId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> ClearShoppingCartAsync(int shoppingCartId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteFromShoppingCartAsync(int shoppingCartId, int productId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<ShoppingCartViewModel>> GetShoppingCartByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> InitializeShoppingCartAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
