using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Concrete.Contexts;
using System.Runtime.CompilerServices;

namespace MiniShop.UI.Extensions
{
    public static class HostServiceExtensions
    {
        public static  IHost UpdateDataBase(this IHost host)
        {
            using(var scope =host.Services.CreateScope())
            { 
                using(var miniShopDbContext= scope.ServiceProvider.GetRequiredService<MiniShopDbContext>())
                {
                    try
                    {
                        var pendngMigrationCount =miniShopDbContext.Database.GetPendingMigrations().Count();
                       if(pendngMigrationCount>0) 
                            miniShopDbContext.Database.Migrate();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                }
            }
            return host;
        }
    }
}
