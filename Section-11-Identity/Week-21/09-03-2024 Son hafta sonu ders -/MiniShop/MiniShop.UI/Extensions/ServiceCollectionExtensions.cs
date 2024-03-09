using FluentAssertions.Common;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyDbContextServices(this IServiceCollection services)
        {
            services.AddDbContext<MiniShopDbContext>(options =>
                 options
                 .UseSqlite(services
                        .BuildServiceProvider()
                        .GetRequiredService<IConnectionBuilder>()
                        .GetConnectionString("SqliteConnection")));

            return services;
        }
        public static IServiceCollection LoadMyIdentityServices(this IServiceCollection services)
        {
            IdentityBuilder ıdentityBuilder = Services.AddIdentity<User, Role>()
            .AddEntityFrameworkStores<MiniShopDbContext>()
            .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                #region Parola Ayarları
                options.Password.RequiredLength = 6; //Parola en az 6 karakter olmalı
                options.Password.RequireDigit = true; //Parola sayısal değer içermeli
                options.Password.RequireNonAlphanumeric = true;//Parola özel karakter içermeli
                options.Password.RequireUppercase = true; //Parola büyük harf içermeli
                options.Password.RequireLowercase = true; //Parola küçük harf içermeli
                                                          //options.Password.RequiredUniqueChars //Tekrar etmemesi istenen karakterler
                #endregion

                #region Hesap Kilitleme Ayarları
                options.Lockout.MaxFailedAccessAttempts = 3;//Üst üste hatalı giriş denemesi sınırı
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(50);//Kilitlenmiş bir hesaba yeniden giriş yapabilmek için gereken bekleme süresi
                                                                                  //options.Lockout.AllowedForNewUsers = true; //Yeniden kayıt olmaya imkan ver
                #endregion

                options.User.RequireUniqueEmail = true;//Her email sadece bir kez kayıt olabilir
                options.SignIn.RequireConfirmedEmail = false;
            });
            return services;
        }

        public static IServiceCollection
            {
              builder.Services.AddScoped<ICategoryService, CategoryManager>();
        builder.Services.AddScoped<IProductService, ProductManager>();
        builder.Services.AddScoped<IShoppingCartService, ShoppingCartManager>();
        builder.Services.AddScoped<IShoppingCartItemService, ShoppingCartItemManager>();
        builder.Services.AddScoped<IOrderService, OrderManager>();
        builder.Services.AddScoped<IMessageService, MessageManager>();

        builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
        builder.Services.AddScoped<IProductRepository, ProductRepository>();
        builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();
        builder.Services.AddScoped<IShoppingCartItemRepository, ShoppingCartItemRepository>();
        builder.Services.AddScoped<IOrderRepository, OrderRepository>();
        builder.Services.AddScoped<IMessageRepository, MessageRepository>();

        builder.Services.AddScoped<IImageHelper, ImageHelper>();

        builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(options => new SmtpEmailSender(
            builder.Configuration["EmailSender:Host"],
            builder.Configuration.GetValue<int>("EmailSender:Port"),
            builder.Configuration.GetValue<bool>("EmailSender:EnableSSL"),
            builder.Configuration["EmailSender:UserName"],
            builder.Configuration["EmailSender:Password"]
          ));
            }
    return Services
}
}
