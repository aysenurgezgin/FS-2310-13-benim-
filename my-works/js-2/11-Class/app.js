"use strict"
//neden kullandık

//Bu konu derin bir konu ve biz C#'la temel programlama bilgisini verdikten hemen sonra object orianted programing başlığı altında ayrıca inceleyeceğiz ama js'te yüzeysel de olsa işimize yarayacak/lazım olan durumlar vardır.Js tamammen object oriented temelli bir programlama dili olmadığı için çok baştan önemseyerek konuşmadık,önemsiz değil bu arada sedece bu konuyu daha iyi oturtacağımız yer C# olacaktır.
//Temel mantık;Bİzim evreni tanımlama algılama biçimimiz programlamaya ilham kaynağı olmuş ve evreni algılarken kullandığımız sınıflandırma teknikleri ilham olmuş.Özelliklere bakarak sınıflandırma mantığı yani.İki durumda değerlendirilebilir;bir özellikleri birde yapabildikleri(Property&Methods=Programlama dilinde bu şekilde kullanırız.)(kedi köpek örn;kedi kalıbını alıp makinesinden köpek çıkmasını beklemeyiz;dediğimiz kalıp=class olacak)
//Kullanacağım verileri belirli bir kalıpta oluşturup daha sonra o kalıba göre tıpkı kedi üretir gibi objeler üretebilirim.

//ies 5  öncesi yani ECMAScript 5 ve öncesindeki tanımlama yöntemini görelim;buradan bile görüceğiz Js'in object orianted olmadığını.Aslında Js 'te ies 5'e kadar class diye keyword yoktu(yani öyle bir sözcük bile yoktu)doğal olarak böyle bir kavram yoktu içinde,şimdi var ama arkada başka birşey yapıyor arkadaki yapılan şeyi yapalım ve öncelikle bir class tanımlayalım;fonk yazdık çünkü js aslında class'lar bir fonk.
//Burada tercihen yaptığımız JS developer'ların da yaptığı bir durum var fonkları isimlendirirken hep Camel Case kullandık(ilk sözcük tamamen küçük geri kalanların ilk harfi büyük)eğer class tanımlıyorsanız Pascal Case kullanacaksın,zorunluluk değil burada ama React kullanırken buna benzer bazı zorunluluklarla çalışıcaz ama bu yüzden React gibi ya da engulur gibi bir freamwork'te çalışacaksak(kütüphaneyle)o zaman ona da alışalım,hem de js developerlarda tercih ettiği bir despraktis;O zaman bir dipnot js'te Class isimleri Pascal Case ile isimlendirilir.
//E bu normal fonk'a çok benziyor di mi ama skope içinde normal bir js objesi ile çalışırken objelerin sonuna iki nokta koyuyorduk ama burada eşittirden sonra çift tırnak"" sonra da (;) koyabiliriz;sonra let'le studentımızı tanımlamak istiyoruz(bu şekilde bir değişken)içrisne isim olarak veririz (ayse,fatma gibi) Eşittir deikten sonra new diye bir keyword'ümüz var(elimde bir kalıp vardı ve kedi üretiyordu ya düğmeye basıp yeni bir kedi üret diyorum new ile=kedi nesnesi üretecek ya)fonk yanında ki Student'ı (Student=kalıp bu)kullanarak yeni bir öğrenci tanımlamak istiyorum.Nasıl;o yukardaki oluşturduğum classın ismini vericwm (yani new Student yazarak)ve tabiki yanına aç kapa parantez ekle yanına
//acaba şuan da Student1 in ne özellikleri var?=Bir değişke olarak tanımladım ya=)student1. yaptıktan sonra çıkanlara dikkat et(tanımladığımız propertyler var/özellik)daha propertylerimize dğer vermedik henüz ama student1'e aktarılmışlar(yapılan şey;ilk olrak fonkta Student diye bir sınıf tanımladık student1inde tip olarakta student tipinde tanımlamış olduk)Her class aslında bir tiptir bu anlamda düşündüğümüzde,dolayısıyla tıpkı daha öncesinde string tipinde bir değişken tanımladım number tipinde bir değişken tanımladım şimdi de diyorum ki;Student tipinde bir değişkenim var artık(letin yanında değişken)

// function Student(){
//     firstName = "";
//     lastName = "";
//     age = "";
// }
// let student1 = new Student();
// student1.firstName = "Ayse";
// student1.lastName = "Gezgin";
// student1.age = 24;
// console.log(student1);

//Js developer olacak kişiler için de üstünde durulması gereken bir konudur.
// Her fonk adını normal aç-kapa parantezi ile yazmalıyız çalıştırırken veya fonk tanımlarken demiştik.Parantez kullanılmadan kullanılırsa farkı algılanabileceği için orada ki espiri classlar da da önümüze çıkıyor bir önceki kodumuz da boş bırakmıştık ama Student luştururken şöyle oluşturmasını varsayabilirdim classımı tanımlarken sen student da oluştururken bana firstnameini söyle gibi daha oluşturma satırında daha bana bunu söyel diyebilirim(constracter yapısı=yapıcı method)Aslında her classın yapıcı bir default değeri vardır zamanı gelince konuşucağız

// şimdiki senaryo productı oluştururken daha ben yazarken name ini ver-fiyatını ver istiyorum;use strick yazınca bir problem yaşadık=pName yeni bie değişke tanımlar gibi olduğu için trickt i kullanmadan önce yazdı ama tam değil di...skope un içinde this ekleyince bu classın içinde ki demiş olduk ve eşittir dedik yine aynısını yazdık ki kafamız karışmasın daha sonrasında
function Product(productName,productPrice){
   this.productName = productName;
   this.productPrice = productPrice;
}
let p1 = new Product("Iphone 13",42500);
console.log(p1); 
// let p1 den itibaren baktığımız da bize anlatılan;new P.. bize fonk diye bir kalıbım var bir class bu calssı kullanarak bana bir tane dea instent daha oluştur bir tane daha product oluştır yani produkt= içinde productname i olan içinde productprice bilgisi tutan bir bölüm daha;
// Değikenleri rem de tutuyorduk tüm değişkenler stek dediğimiz bir dbölümde tutuluyordu objerlin hiçbiri stekte tutulamaz objeler her zaman heep te tutulur new de sonra yazılan şeyi (Product ı)tanımlı olan productımızı alır ve burada yani bir tane product oluşturur(pn,pp) ve içine değerlerini de yazar ve bunu heed de nerede kaydetmşse onun adres bigisini stekde tutar yani p1 in karşısında yazan şey(p1=ref addr;) o yeni oluşturulan obje heepteki şurada duruyor demek sonra ben clg de p1 i yazdır diyorum ya şunu yaptırıyor;gidşyor p1 e stekte hangi adresi gösteriyorsa heepteki karşılığına gider ve bu adresini okuyor ve steke geri döndürüyor ve bana kullandırtıyor.
//Bellekte stack ve heap bölümü var Elimşzde product diye bir classımız var sonra p1 diye bir değişken tanımlıyoruz stackte=p1 içinde bir adres tutacak bu adres genlede hegzadesimal kodlaral ifade ederiz(örn=A45C) buraya not etti o zaman eşittiri görünce karşısında diyor ki new Product  o zaman geliyor heap kısmına ve product oluşturuyor ve içerisine bilgileri yazıyor ve stacteki adres heapteki procukt bilgilerini referens ediyor.p2 satırı çalışıınca da;stack kısmına p2 yi oluşturuyor (örn=)p2=CF41) adresindesindeki nesneyi işaret et diyor ve heap kısmında da hemen bir product daha oluşturuyor ve burada oluşan pruductın
//içindeki datalar farklı (instens)// p1 gibi onlar artık basit tipler değil ,içinde referens tutuyor

let p2 = new Product("Samsung S22",37000);
console.log(p2);//adresleri aynı olduğu için aynı nesneyi fade etmiş olurlar =) let p3 =p1 yazarsam