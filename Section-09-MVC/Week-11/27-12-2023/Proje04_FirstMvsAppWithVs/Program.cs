var builder = WebApplication.CreateBuilder(args);
//*�nce uygulmaya� olu�turucuyu al�yorum
//!AddControlerW�thV�ewa  methodu,bu projenin bir mvc uygulams� olmas�n� sa�lar.Burada ContolletW�ity servisini IOC(Servis Havuz) i�ine koymu� oluruz.Uygulama ihtiya� duydu�u her anda bu havuzda  bu bilgiyi elde edbilir.

//Peki bu MVC nedri?
//Model:Projemizdeki veri, veri taban� gibi i�leri y�r�tt���m�z b�l�m.
//View: Projemizdeki arayay�z� temsil eder b�l�m:
//Controller:Gelen t�m istekleri

builder.Services.AddControllersWithViews();
//*hangi �zellikler oluca��n� sa�lam�� oluyoruz,servis le eklemi� oluyorum servis eklemnmesine sa�lam�� oluy�ruz �zellik belirleme yani.Ioc ye bak havuz servisleri i�ine atar sonra buradan �a��rmam�z� sa�lar.SErvis k�zm� burada biter

var app = builder.Build();
//in�a ettim elimde app var art�k run derim ve aya�a kald�r�l�r uygulamma 

// Configure the HTTP request pipeline.==ya�am d�ng�s� olan k�s�m
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//ara yaz�l�m k�sm� bu k�s�m her istek olunca bunlar tekrar �al��uryor.build ve run aras�
app.UseHttpsRedirection();
app.UseStaticFiles();
//�st k�s�m klas�r olu�turmakla ilgili statik method web uyg.root diye dosya var onun i�inde demek.
app.UseRouting();

app.UseAuthorization();
//https://localhost:5069/Product/AddProduct
//https://localhost:5069/
//https://localhost:5069/Home/Index

//istekte bulanuacaksan ben �u �ekilde ��z�mlerim der ��z�m k�sm� burda
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//bu k�sma kadar
app.Run();
//action i� yapan method