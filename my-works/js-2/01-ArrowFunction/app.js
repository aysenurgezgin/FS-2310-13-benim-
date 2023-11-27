function selamVer() {
    console.log("Merhaba, burası klasik bir function");
};

// A is6 ile beraber bizim daha kolay basit kod yazmamızı sağlayan kullanım şekli arrow fonk; kullanmak zorunlu değil
// react öncesi neden bu konu bizim için önemli? =çübkü react'ın bazı komutları direkt olarak arrow fonksiyon şeklinde tanımlanmış
// örn:bir şeyin içerisine function vemke gerekiyor ve bu diyorki arrow fonkla yazılmalı bu gibi durumlar için bu kullanım şeklini de bimen gerekiyor.
// Peki nasıl yazılır?=1) bi kere arrow fonk tanımlarsnız bu fonk bir değişken gibi düşüneceksin  ve bir fonk tanımlandıktan sonra içine yeni bir değer atamayacagımız 
// için fonk genelde CONST keyword' ü ile tanımlanır sonrasında aynı üsste olduğu gibi (selamVer2)dedik ve bu fonk ismi gibi gözükmüyor tanımladığımız şey
// şu ana kadar yazdığımız isimler teorik olarakçelişkli gibi gözükebilir sabit bir değişken deyine ama çok takılma:D değişken ama değeri değiştirilenilen bir değişken tanımlar gibiyim
// eştiir 32 desem 32 adında bir number tipinde bir değişken tanımlamış olurum ama ben bunun için de bir fonk tutmak istiyorum;
// bu fonk arrow fonk denmesinin sebebi: ok demek => diyip bundan sonrada skobumuzu açıyoruz; ve bu da bir fonk olmuş olur(sanki bir değişkeni çağırıyormuşuz gibi ama bu fonktur)
// Nereden biliyor js bunun bir fonk olduğunu; ilk olarak eşittirin karşısındaki ()dan sonra da bu bir fonk ama => dan da bu bir arrow fonk dur diye anlamış oluyor ve diyor ki bu yüzden ()bu kısım boşmuş diyor normlade önce parantezin içinde isim yazdığımız için o yüzdendir diyor.


// const selamVer2=()=>{   
//     console.log("Merhaba, burası bir arrow function dur");
// };

// selamVer();
// selamVer2();


// B farklı örnekler; mesela bu selamVer'i aslında parametreyle(ad) kullansak; bir isim gönderebilirdik bu ismimle fonk :

// const selamVer3 = (ad)=>{
//    return koyunca ne farkı luyro ya da consolda neden aynı şekilde gözüküyorlar return eklesekte eklemesekte
//     console.log("Merhaba " + ad);
// }
// selamVer3("Ayşe Nur");
// Burada "Ayşe Nur" ad değişkenine gönderilmiş olacak oda clg de "Merhaba Ayşe Nur" yazacak

// C Birden fazla parametre gerekseydi; o şekile bir fonk yazalım;Adı topla olan bir fonk,bu topla fonk iki gönderşlen sayıyı toplayıp geri döndürecek(return ile)

// const topla= (sayi1, sayi2)=>{

//     return sayi1 + sayi2;
  
// }
// console.log(topla(null,5)); 
// consolda 5 yazar

// sadece bir sayı gönderseydi consolda NaN veriyor;birinci sayıyı yazdırı ama ikinci sayı yazmadığmız için clg de yazdırsak değer yazmadığımız için undefined yazar.

// Ç) ilk iki sayı olsunda 3. sayıyı göndermeybilirsin demek istediğimde;şuan toplamaya göre düşündüğümüz için,işleme tabi tutmayacağım sayıyo"0"olarak belşr bunu da const kısmına atanan sayı değerleri içi kısmında halledebiliz;
// const topla= (sayi2,sayi1=0,sayi3=0)=>{
//     return sayi1 + sayi2+ sayi3;
  
// }
// console.log(topla(4));
// ama sayı 1 e 0 diyi sayi2 ye 0 demekten vaz geçersek consolda NaN yazar; burda ufak bir kural ihlali yapmış oluruz;bir fonk prametre listesi kısmınada(sayı br 2 yazdığımız yer) mutlaka son sıaralda olmlıdlır default verdiğimiz parametreler yapmak istersende sayi 2 yi başa koy o zamaan kardeş
// null sayısal bir işlema tabi tutulabilen bir değer ama undefined tutulamaz neden? : undefined sayısal bir değer aynı zaman da ama maalesef aritmetik işleme tutulamıyor fakat null aslında içinde hiç bir şey olmayan string se tırnak tırnak sayıysa sayıların varsayılan değeri 0 olduğu için 0 ;dolayısıyla
// bu kısıma ()verilirse hata vermez

// D) arrow fonk da paremetre gönderme işinin normel fonklarla aynı olduğunu gördük, sadece bir nüans var(parametre listesi açısından tek= hani vardı ya(sayı1 sayı2 o kısım ));onun dışında başka nüans daha var o da: 
// patametre listesi olarak farkı;yukarıda ki selamVer in benzerini içerisine mesela ad göndereceğimiz şekilde bir fonk olarak yazalım;js :eğer bu arrow fonklarda tek bir parametre yolluyorsak şu ()parentezlri yazmak zorunda değilsin diyor(öenmli olan kısım tek bir paramtreyse)bunun öğrenemeizin sebebi bu şeklide yazılmış olan 
// çok fazla fonksiyon görücez ileride/kullan ama normalini öğren sonra kullan

// const selamVer4 =(ad)=>{
//     return console.log("Merhaba "+ ad);
// }
// selamVer4("Halil");

// E) son bir nüans dediğimiz kısım: Eğer tek bir satırlık kodumuz varsa arrow fonk içinde ve return yapıyorsak;(35.satırda olduğu gibi) bunu daha yalın yazma şansımız var. skoplara ihtiyacım yok diyor js
// 35 deki gibi yazmak yerine;

const topla2=(sayi1,sayi2)=> sayi1+sayi2;

// neyi return etmek istiyorum ben?;(sayi1+sayi2)yi
// şuan da bunları toplar ve return eder nereden çağırılırsa,bunu yapmak içinde yapman gereken şu şekide çağırmak;
console.log(topla2(5,20));
// burada nasıl çaışıyor?=topla2'yi çağırdığımda 5'i sayi1'e 20'yi sayi2'ye atayacak ok(arrow)fonk kod bloğu oktan hemen sonra tek satırlık return'üm varmış ozaman 5+20 işlemini kendi biz yazmasakta kendi gizli bir return sözcüğünü barındığı için bu 25 'i return edip' consolda 25 yazacak


// Modern js diyoruz ama günümüz o popüler kütüphanleri kullanırken(react,enguler...gibikütüphnelrş)aslında yapmış olduğumuz;bizim uygulamamız en son model js özellikleri ile yazıyoruz ama aslında bunu çalışır hale getirirken bunları ilk eski sürümlerine  döndürmüş oluyoruz.
// is5 öncesine nedeni= eski tarayıcılarda benim programımı çalıştırabilmesi için sorun yaşamasın diye.Bunu yapmak için bir sürü converter dediğimiz kütüphaneler vsler var ama(decompiler dediğimiz)react bizim için zten bunları yapıyor bu yüzden bu kütüphaneler popü ama arkada bunun olduğunu bilmen gerekiyor
// Biz bunları daha kolay kod yazbilmek için kullanıyoruz,geliştirme ortamımızın daha stabil daha temiz bir kod olması için mecur değiliz ama günümüzde ki teknolojiler bunu kullanıyorsa neden kullanıyorlar bize bu imkanı oluşturabilmek için (daha anlaşılırda olması için)Ama şunu da bilmelisin bugün böyle eski tip
// fonk artık kullanılmayacak diyebilir mesela hiç demedi ama diyebilir.