//2) baş kısmı app.js kısmında o kısma da bakarsın; 
// bir modülü oluşturmak için eksta birşey yok sadece kafama uygun bir isim verdim yani uzantısı aynı js dosyası yani aslında aynı js dosyaları sadece birbirleriyle entegre çalışabilecekler burada ki entegrasyonun espirisi de şu adosyasındayım örneğin
// b dosyasında ki her şeyi kullanmak istiyorsam eğer b  dosyası dışarıya açık olmak zorunda a dosyadı da dışarıya açık olan dosyayı içine çekmek zorunda bunlara da export ve inport diyoruz.Eğer ben a dosyasın da çalışıyorken  b dosyasını kullanmak istiyrsam o b dosyasından export yapmış olmalıyım yani bu dışarıya açık olsun demeliyim a dosyasına da o dışarıya açık olan dosyayı buraya import et (çek/getir ithal)demeliyim.Eksport ya da import işlemine geçmeden önce
 
//Bizim burada ki senaryomuz şu olsun; daha önce yapmış olduğumuz bir toplama işlemi vardı:içerisine birden fazla da sayı gitse toplayabiliyordu,ben hangi js dosyam da çalışıyorsam çalışayım bu fonksiyonu kolaylıkla çalıştırmak istiyorum,her yerde bir daha yazmak istemiyorum; bu tarz işlemler için bu modülü hazırladık:

//a) burada öğrenmiş olduğumuz arrow fonk(rest parameters değil mi?) kullanlım,daha önceki yaptığımızla benzer şekilde yaptık; bir değişkenin içine alıcam(const) sayı dizimi = yaparak öncelikle dışardan geleni alıyoruz bunu bu şeklde almayıp kullandığımız durumlarda var tabiki,akabinde bir tane toplam değişkeni tanımlıyoruz başlangıç değeri 0 olan sonrada bir for döngüsü bitince yine const skobunun içindeyken return ettiriz nereden istiyorsak oradan geri döndür

// const getTotal=(...numbers)=>{
//     const numbersArray=[...numbers];
//     let total=0;
//     for(let i=0;i<numbersArray.length;i++){
//         total+=numbersArray[i];
//     }
//     return total;
// }

//neden comment olduğunu ;  
// 7)!! de anlayacaksın şimdiliş 5)altındaki export kısmına kadar devam et.

// app.js e gitmeden önce index.html ye gidelim eğer artık moduls sistemini kullanacaksam;yani bir yerlerden import etmek eksport edilebilmesini sağlamak amacıyla şuan da ana dosya(app.js)benim kafamdaki myModule ise ihtiyaç halinde içinde kullanacağım şeyleri barındırıyor
//index.html de script içine app.js bağladığımız için bu bir modul sistemine sahip olan bir dosyadır demiş oldum. src kısmının önüne bir ilave yapmam gerekiyor sonrası kısmı da olur src'nin; burada yapmam gereken tek şey bu js çalışmasının tipinin modül tipin de olduğunu söylemek

// react gibi kütüphanler bizi bu zahmetten kurtaran şeyler.

// 5)dışarıya açmak için; myModule.js e gelip dışarı açalım, bunu yapmak için farklı yollar var ama biz şuan da bir yolla yapıcaz; genelde en son satıra gelip export sözcüğünü kullanıp tıpkı app.js'te yaptığımız gibi
// burada hangi fonk dışarı çıkarmak istiyorsak onun adını yazarız

// export {getTotal};
//    7)!! de anlarsın neden comment olduğunu

// bunu da bağladıktan sonra consolda app.jste yazdırılmış olunan sayıların toplamı gerçekleşmiş oldu

//7)Başka fonk eklmeden dışarı çıkarmanın başka yoluna daha bakıcaz; ilk olarak export kısmını comment yap.Yani dışarı aktarmamış olduk,fonk tanımladığımız kısma gel ve;
// baş kısmına export yaz ve clg ye bakınca yine çalışmış olduğunu göreceksin

export const getTotal=(...numbers)=>{
    const numbersArray=[...numbers];
    let total=0;
    for(let i=0;i<numbersArray.length;i++){
        total+=numbersArray[i];
    }
    return total;
}
// Yani burada üst kısımda belki 10 tane fonk yazsam bile canım hangisini istiyorsa onu dışarıya aktarmış olurum
// Developerlar'ın kullandığı alttaki kısım ikinci aktarma yöntemini tercih ediyor. 

//Bir react için örnek vericek olursak ; rfce diye bir snipıt var ya da rfc bizim için otomatik olusturuyor export ve fonk yapısını
//(react da aslında görülen kod js kodu burada sadce react'i ilgilendiren mantıksal bazı şeyler var onu da 26 kasım da ki derste görücez)
