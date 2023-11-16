//1)toString
let isActive=true;
alert(typeof isActive);
//mesaj da boolean olmasının sebebi;mantıksal değer taşıyan değişkenlerin içindeki verinin tipi:özellği:içinde true ya da false bir değer tutabiliyor.
console.log(isActive,typeof isActive); // consolda true 'boolean'yazmaktadır
//consolda boolean(değişkenin türü) mesajı verdi.
//Stringe dönüştürme işlmemi yaparken kullaılacak yapı;
// String komutu=parantez içine na yzılırsa onu string e dönüştürüyor(bizim de elemizde boolean tipte isActive diye bir değişke var)ynına uazınca consolda 
// gözükmesi için clg typeof isActiveString yapıp bakınca tipi için;isActive artık Stringolmuş olur.=Değişen şey;değeri aynı kaldı ama tipi dtring olrak d
// değiştirmiş olduk=mesela let isActive olrak değeri küçük harfli olan(boolean tarzda) true yu büyük harfele döüştürebilmek için clg(isActive.toUpperCase())ile 
// büyük harfe döüşebilmesi için boolean olan tarzı ilk olarak toUpperCase in (özelliğini kullanabilmesi için;bir string i yani metinsel bir şeyi ancak büyük harfe
// döüştürebildiği içi)kullanımı için string tarza çevirmemiz gerekiyor.
let isActiveString=String(isActive);
console.log(isActiveString ,typeof isActiveString);//consolda true string yazmaktadır.
console.log(isActiveString.toUpperCase());//boolean tarzı stinge çevirip yazdırmaya çalıştığımız için(metinsel)uppcase çalıştı ve consolda TRUE yazmaktadır.
// console.log(isActive.toUpperCase()); yazdığımızda consol da bize hata veriyor ndeni:isActive in içinde taşıdığı değere toUpperCase diye bir fonksiyonu ben uygulyamam
// çünkü isActive Stringdeğil. isActive aslında booleanlara yazılacak şeyler

let price=37500;
console.log(price,typeof price);//consolda 37500 'number'yazmaktadır.
let priceString= String(price);//string komutu içine yazılan (ya da istenilen)şeyi stringe dönüştürmek istersek yazmamızı mümkün kılar.
console.log(priceString,typeof priceString);//Şimdi de consolda koyu siyah bir biçimde 37500 yazdı(diğeri mavi renkteydi)tipi de (typeof eklediğimiz için)stringe dönüşmüş oldu


// yan yana yazdırmak istiyorum;
let firstName="Didier";
let lastName="Drogba";
// console.log(firstName,lastName);//şuan da consolda yan yana yazmaktadır.
// Şöyle bir seneryo da sadece yazdırma değil uygulamanın içinde bir yerde firstname ile lastname in birleşmiş halini istiyorum bunu içinde değişken gerekiyor ;metinleri birleştirme
// için gerkli olan değişken ismi de fullName dirr.bunun içinde; = iki değeri +ile topluyorum(like math)

// let fullName=firstName+lastName;
// console.log(fullName);//consolda ikisini yapıştırdı DidierDrogba yazıyor.boşluk için;

let fullName=firstName+" "+lastName;//ikisi arasına tırnak içi bir boşluk bırakırsan consolda şuan Didier Drogba yazıyor.(tam da bizim istediğimz gibi)boşluk karakteri koymuş olduk.
console.log(fullName);

//+kullanımı ;kullanıldığı yere göre kullanımı farklı olablir.
console.log("Ali"+"Veli");// consolda AliVeli yazıyor;bunlar metin dedi.metin ise de ben bunları birleştiririm dedi
//eğer bunlar sayı olsaydı;
console.log(4+9);//13 yazdı consola
console.log("Ali"+9);//consolda Ali9 yazmaktadır: ali metin 9 da sayı ali metin olduğu içn otomotik olarak 9 un türünü metin olarak çevirdim ve birleştirme yaptım.+ metin birleştirme operatörü oldu.
console.log(9+"Ali");//consolda 9Ali yazdı.
// +operatörünü kulladığımz zaman iki şeyden birini yapmaya çalışıyor:mtin birleştirme,toplama.Duruma göre js kendi karaını veriyor eğer metin derse bunu birleştirmeye çalışıyor,sayıda toplama
console.log("10"+9);//consolda 109 yazmaktadır.
console.log(10+"9");//yukarıdaki ile aynı.
console.log((20+5)+"9");//consolda 259 .parentezi koymazsakta;
console.log(20+5+"9");//conolda yine aynı şekilde dir.
console.log(20+"5"+9);//consolda 2059 yazmaktadır.metin birleştirme yaptı!string varsa hepsini string olarak algılıyor.

// antrenman olarak alternatiflere çalış! şöyle olrasa ne olur böyle olursa ne olur diye bak


//2)Number
console.log("6"/"3");//consolda 2 yazmaktadır.normalde ikiside string olduğur halde matemeatşksel işlem yapmaması gerektiği halde bu ikisini otomatik olarak sayıya dönüştürüyor ve işlem oluyor siyah renkli olur,kendim;
//numnber komutumuzun kullanımı;içine ()bir string olarak işlem yazrsak üstteki örnekteki gibi çalışmıştı ama bizim verdiğimiz komutla bu işlemin sonucu konsolda mavi olur çünkü 65 bir number
console.log(Number("65"));//mavi renkli bir 65 çünkü number
console.log(Number("Bright"));//consolda NaN verdi;dönüştürülebilecek birşey değil demek.
console.log(Number("  756  "));// bir sıkıntı olmadan 756 yı consolda sayıya çevirebildi.Bu tarz string ifadeleriniçindeki gözükmeyen karakterlere white space denir(boşluk,enter,tub gibi)gözükmeyen etkisi olan karakterlerdir.
//Demmek ki Number (fonkisyonu/kendime not metot fonk farklarının iyi bil) metodu çalışırken önce başta ve sondaki white space leri ortadan kaldırıyor ondan sonra kalan değere bakıp bunu sayı değeri olarak kabul edip edmeyeceğine 
//bakıyor ve ona göre işlem gerçekleşmiş oluyor. Ama sayı için de bir boşluk bile olsa consolda alınacak değer NaN oluyor.
 
