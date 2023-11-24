const display= document.querySelector(".calculator-input");
const keys= document.querySelector(".calculator-keys");
// a
 let displayValue="0";
// b
function updateDisplay(){
    display.value= displayValue;

}
// c

// d
keys.addEventListener("click",function(e){
    const element = e.target;
    const value = element.value;
    // e
    if(!element.matches("button"))return;
    switch (value) {
        case "+":
            
            break;
    
        default:
            break;
    }

});







//a bir sayı yazdığımızda onu görmek isteriz onları string olarak kullanıcaz hesaplama işlemine
// tabi tutunca number olmasını istediğimiz için string yapıcaz ilk olrak(tırnak için de yani)

// b ben ne zaman ekranı güncellemek istediğim de ilk önce ekranda görünmesini istediğim şey için bir
// function tanımlıyacağım =iside neyi güncellemek istiyorsam onun ismi olsun= updateDisplay()
// neyin valusunu güncellemek istiyorum= const la display dediğimiz (.calculator-input)

// c henüz konsolda birşey yok çünkü bireşy çağırılmadı; görebilmek için şu aşamda yapacağımız şey updateDisplay(); index html de yaptığımız value=0 ile aynı işlemdir ama
// bir taraftan bir tuşa basıldığı zaman displayValue ya diyeceğim ki şunu yaz bundan sonra da updateDisplay çağırıcam ve yeni değer gelmiiş olacak

// d şimdi yapmak istediğim şey butonlarımın bir kısmı operetor bir kısmı number sayılar bir tanesi ondalık vs ama hepsi birden şuan yukardaki değişkenlere bakarsak keys in içinde
// update ten önce gelip diyorum ki bu keys denilen arkadaşa addEventListener ekle ve hangi eventi takip etek istiyorum tıklandığında yani click olunca bu click olunca hangi fonksiyon çalışsın
// ayrı function şeklinde yazılabilir ama şuan bu kısıma yazdık event yada istediğin herhangi bir isim verilebilir ama genelde  verilen isim e ya da event dır. kavramın adı o olduğu için e yi de 
// alıyorum sonra parantezimin yanına gelip skopumu açıyorum

//  e kullanıcı yanlışlıkla buton yerine başka yerlere de tıklayabilir bunun önüne geçmek için şimdi yaılan kod tıklanan yerin value su şuna eşitse şunu yap oysa bunna tıkayınca hiç bu kontrolleri yapmaya 
// gerek olmadığı için daha buradayken şu soruyu sorayım=bak bakalım şu element ne onu bir anlıyayim elemnt calculater-keys ise çıksın gitsin demek oluyor ya da butonsa devam etsin,işin özü işiöe yarama
// yacak bir yere tıklanırsa kodun kalan kısmını çalıştırmayayım;yukarıda alınmış olan elementi burada çalıştırıcam,eğer element ve nokta diyip burada basit bir eşleşme dediğimiz bir yapıyı kullanıcaz yani elementin yapısı
// sana birazdan vereceğim şeyle eşleşiyormu neyle? bu element bir div mi, button mı demek olacak = .matches sonra parantezini açıyorum yine string bir şekilde diyorum ki button=eger(element neydi?= tıklanan şey)tıklanan eleman bir
// buttonsa demek yerine buton değilse çıkgit çalıştırma bunları demek için olaya tersten bak !koy yani!element =buton değilse bu durumda skoba bile gerek yok tek şey var yazmaam gereken =break burda durdur kesama buna kızdı o yüzden 
// öğrendiğimiz başka şey olan return ü kullanıyoruz(fonk içinde geriye bir değer döndürürken kullanıyorduk orada iki iş yapıyordu orada fonk bittiğini de söylüyor)burada da hiçbirşeyi geri döndürmeden bu fonk u bitiriyor
// o anda basılan yer benim calculater-keys içiçnde ama butonlarımdan biri değilse uygulamanın bundan sonraki satırları çalışmayacak;peki butonsa= returndan sonraki kıma geçecek temiz kod için gereken switch kısmına geçiş yapıyoruz hatta statmen kısmını seçiyoruz
// ilk olarak  değerini kontrol edeceğimz şeyi yazıyoruz nyin değerini anlamaya çalışıyoruz value yani içinde artı mı var eksi mi var onu anlamak için bakmam gerek yer key kısmıdır
// diyelim ki bizim bir fonk var adı da opereator u işlemek harekete geçiremek için handle etmek yakala operetorle ilgili işleri yap demek oluyor  eger valu + ise o handeleopeparatora git ve sonra dur demek bu bir döngü değil ama bir akış
// kontrol mekanizması bunu görünce altta başka case lar varsa bunkara bakmayıp devam edip gidecek