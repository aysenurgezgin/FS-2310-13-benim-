// 1)Bir js programını  geliştirirken şu ana kadar tüm örnklerde bir ap js dosya oluşturup ne yazdıysak her şeyi oraya yazdık ama gerçek dünyada yüzlerce kod yazamaız gereken durumlada parçalayarak yazmamız gerekecek tek bir dosya da çalışamayız,fonk fonk ayırırsın orada yaptığın şeyi işlev işlev öyle ayırırsın mesela ürün kaydı yapan js dosyan olabilir ama içinde bir sürü ürün kaydın olabilir ama oranın asıl işlevi; ürün kaydetmektir gibi,nihayi olarak yine ideal olan(kolaylık açısından) şey herşeyin tek bir dosya içinde olması ve tarayıcıyı öyle çalıştırmaktır.Preformans olarak bir
// reackt kütüphanesi olan nextcies (yazımını bilmyorum?) kütüphanesi var reack üzerinde çalışan ve reackt in offical olarak desteklediği bir reackt kütüphanesidir. mesela nextjs bize default olarak bize parça parça olan kodu tek bir hale getirebilir (derler)nasıl= nerde ne gerekiyorsa oara o js kodlarnını olduğu bir dosya.
// Biz bir çalışmayı yaparken sık sık parçalarız o parçalar da çalışıtrız ;js te nasıl yapıcaz?= moduls bizim bu iş yapmamızı sağlayacak olan kavramın adı nasıl bir mantığa sahip? : moduls üzerinde sağ tuşa basıp new file yap (myModule.js)yazıp bir tane dosya oluştur,bir modülü oluşturmak için eksta birşey yok sadece kafama uygun bir isim verdim yani uzantısı aynı js dosyası yani aslında aynı js dosyaları sadece birbirleriyle entegre çalışabilecekler burada ki entegrasyonun espirisi de şu adosyasındayım örneğin
// b dosyasında ki her şeyi kullanmak istiyorsam eğer b  dosyası dışarıya açık olmak zorunda a dosyadı da dışarıya açık olan dosyayı içine çekmek zorunda bunlara da export ve inport diyoruz.Eğer ben a dosyasın da çalışıyorken  b dosyasını kullanmak istiyrsam o b dosyasından export yapmış olmalıyım yani bu dışarıya açık olsun demeliyim a dosyasına da o dışarıya açık olan dosyayı buraya import et (çek/getir (ithal))demeliyim.Eksport ya da import işlemine geçmeden önce (Devamı myModule.js klasöründe)

// 4) bu app.js içinde ilgili bu totel metodunu fonksiyonunu burada kullanmak istiyorum(normalde yapmam gereken bunu direkt kullanabilmem için bu dosyada var olması gerekiyorv  yani getTotal ()diye tanımlamış olamam gerekiyor ama yok)
// o yüzden benimm buraya import etmem gerekiyor nerden edicem? = myModule.js'tin içinden peki şuan import(bu kısım export olamayacak mı?) etsem olur mu? = olmayacak çünkü onu import etmedik ;eksoprt edilmediğide nasıl olacak?

// basit bir mantık var=süslü parantez aç ve sonra alacağın fonksiyona vereceğin ismi söyle ya da alacağın ilgili modül dosyasından alacağın fonksiyonun adı nedir onu söyle.gettotal dediğimde ben oradan gettotal i alıcam diyorum peki nereden? =süslü parantezin dışına çıkıyorum
// from diyorum şuradan al diyorum ve string("") olarak şunu söylemem  gerekiyor iki iç kısma "./myModels.js'in"(sunucu da çalıştığımız için) yolunu göstermem gerekiyor aynı yerdeyiz aynı yerde olduğumuz için direkt yazabiliriz"./myModule.js"tabi ki bir klasörün içinde olsaydı onun yolunu gösterecektik(resim dosyasıyla aynı mantıks)
//Ama şuan da bir sorun var myModels.js dışarıya açık değil ki içeriye aktarılabilsin yine de bir dene clg(getTotal(5,7))
// unutma bulunduğun klasör demek için "./"diyip devam et & "../" bu da üst klasör demek

// import {getTotal} from"./myModule.js";
// console.log(getTotal(5,7)); ama bunu my modulle bağlayınca alttaki kodla beraber yazınca sonuç olarak consolda 12 yi görebilirsin.

//uyarı verdi =consolda myModel.js'i tanıyamadığını söyleyen,ben bunu anlayamıyorum çözümleyemiyorum  diye dediği bir mesaj veriyoer;çünkü myModele.js dışarıya açık değil;
//dışarıya açmak için; myModule.js e gelip çünkü dışarıya açacağımız şey o(5)te demaı yani myModule.js kısmında); 


import {getTotal} from"./myModule.js";
console.log(getTotal(9,7));


// 6) Sonuç olarak = benim dosyam da getTotal olarak bir fonk benim klasörümde olmamasına başka bir dosyada olamasına rağmen ben onu dışarı çıkarttım ve buraya da aktarma işlemini yaptığım için kullanabildim.

//Henüz başka bir fonk yazmadan dıaşıya çıkamranın başka bir yöntemine bakalım;(7))myModel da;

