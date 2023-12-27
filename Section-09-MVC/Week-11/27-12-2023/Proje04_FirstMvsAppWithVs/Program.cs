var builder = WebApplication.CreateBuilder(args);
//*önce uygulmayaý oluþturucuyu alýyorum
//!AddControlerWÝthVÝewa  methodu,bu projenin bir mvc uygulamsý olmasýný saðlar.Burada ContolletWÞity servisini IOC(Servis Havuz) içine koymuþ oluruz.Uygulama ihtiyaç duyduðu her anda bu havuzda  bu bilgiyi elde edbilir.

//Peki bu MVC nedri?
//Model:Projemizdeki veri, veri tabaný gibi iþleri yürüttüðümüz bölüm.
//View: Projemizdeki arayayüzü temsil eder bölüm:
//Controller:Gelen tüm istekleri

builder.Services.AddControllersWithViews();
//*hangi özellikler olucaðýný saðlamýþ oluyoruz,servis le eklemiþ oluyorum servis eklemnmesine saðlamýþ oluyýruz özellik belirleme yani.Ioc ye bak havuz servisleri içine atar sonra buradan çaðýrmamýzý saðlar.SErvis kýzmý burada biter

var app = builder.Build();
//inþa ettim elimde app var artýk run derim ve ayaða kaldýrýlýr uygulamma 

// Configure the HTTP request pipeline.==yaþam döngüsü olan kýsým
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//ara yazýlým kýsmý bu kýsým her istek olunca bunlar tekrar çalýþuryor.build ve run arasý
app.UseHttpsRedirection();
app.UseStaticFiles();
//üst kýsým klasör oluþturmakla ilgili statik method web uyg.root diye dosya var onun içinde demek.
app.UseRouting();

app.UseAuthorization();
//https://localhost:5069/Product/AddProduct
//https://localhost:5069/
//https://localhost:5069/Home/Index

//istekte bulanuacaksan ben þu þekilde çözümlerim der çözüm kýsmý burda
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//bu kýsma kadar
app.Run();
//action iþ yapan method