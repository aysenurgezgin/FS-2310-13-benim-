﻿using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete.Repositories
{
    public class OrderRepository:GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(MiniShopDbContext _context):base(_context)
        {
            
        }
        MiniShopDbContext MiniShopDbContext { get{ return _dbContext as MiniShopDbContext;  } }

        public async Task<List<Order>> GetAllOrdersByProductIdAsync(int productId)
        {
            var result= await MiniShopDbContext
                .Orders
                .Include(o=>o.OrderDetails)
                .ThenInclude(od=>od.ProductId)
                .Where(o=>o.OrderDetails.Any(x=>x.ProductId==productId))
                .OrderByDescending(x=>x.Id)
                .ToListAsync();
            return result;
        }
    }
}
