using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Data.Concrete.Repositories;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.Helpers.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MiniShopDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);

builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<MiniShopDbContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    #region Parola ayarlarý
    options.Password.RequiredLength =6;//Parola en az 6 karakter olmalý.
    options.Password.RequireDigit = true;//Parola sayýasal
    options.Password.RequireNonAlphanumeric = true;//Parola 
    options.Password.RequireUppercase = true;//Parola 
    options.Password.RequireLowercase = true;//Parola 
    /* options.Password.Required = 6;*///Parola




    #endregion

    #region Hesap kilitleme Ayarlarý
    options.Lockout.MaxFailedAccessAttempts = 3;//Üst üste giriþ hatalý giriþ deneme sýnýrý
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(15);//kilitlenmiþ bir hesaba yeniden giriþ yapmabilmek için gereken bekleme süresi
    //options.Lockout.AllowedForNewUsers = true;


    #endregion

    options.User.RequireUniqueEmail = true;//Her Email sadece bir kez kayýt olabilir.
    options.SignIn.RequireConfirmedEmail = false;

});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/";
    options.AccessDeniedPath = "/Account/AccessDenied";//*yetki olmayýnca nereye gitsin
    options.ExpireTimeSpan = TimeSpan.FromDays(45);
    options.SlidingExpiration = true;
    options.Cookie = new CookieBuilder
    {
        Name = "MiniShop.Security.Cookie",
        HttpOnly = true,
        SameSite=SameSiteMode.Strict     //*siber güvenlik amaçlý (Sýký mod)mikro servis mimarisi =büyük çaplý projerlerde
    };
});
//*Çýkmadýðýn süree login olarak kalma komutu nedir?

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddScoped<IImageHelper, ImageHelper>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
