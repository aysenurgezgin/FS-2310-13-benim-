using AspNetCoreHero.ToastNotification;
using MiniShop.UI.Extensions;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        #region ServiceRegion
        builder.Services.AddControllersWithViews();
        builder.Services.LoadMyDbContextServices();
        builder.Services.LoadMyIdentityServices();
        builder.Services.ConfigureApplicationCookie(options =>
        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        builder.Services.AddNotyf(options =>
        {
            options.DurationInSeconds = 3;
            options.IsDismissable = true;
            options.Position = NotyfPosition.TopRight;
        });
        #endregion


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


        #region Route
        app.MapControllerRoute(
                 name: "products",
                 pattern: "urunler/{categoryUrl?}",
                 defaults: new { controller = "Product", action = "Index" }
                 );


        app.MapControllerRoute(
            name: "productsadmin",
            pattern: "yonetici/urunler/{isDeleted}",
            areaName = "Admin",
            defaults: new { area = "Admin", controller = "Product", action = "Index" }

            );
        app.MapAreaControllerRoute(
            name: "Admin",
            areaName: "Admin",
            pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
        );

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        #endregion



        app.UpdateDatabase().Run();
    }
}