let result;
//  tam sayı gereken durumlarda parseInt 
//  örtülü dönüştürücü strinleri kaldırıyor tırnak dönüşrüsüleri dene/başlangıçtan itibaren alınması gereken sayıları
//  alır(tipi string olması durumu =number a çevirmen gerekebilir) to fixed kullanılış amacı
result=parseInt(10.9);
result = parseInt("10.4");
result=parseFloat("101.56");

let num=10.37853;
result=parseFloat(num.toFixed(4));
result=num.toFixed(4);
//noktadan sonraki kısım (ondalık kısım)
result=num.toPrecision(4);
// 4 olacak şekilde ayarla toplam(sayının toplam basamak sayısı)

//yuvarlama meselesi (sınıf metodlar)
result=Math.round(2.4);
result=Math.round(2.5);
result=Math.ceil(2.1);
//tavana yuvarlar
result=Math.floor(2.9);
//tabana yuvarlar
//kayan noktalı sayılar
result=Math.round(2.499);

//üs alma meselesi
result=Math.pow(5,2);
result=Math.pow(4,3);
//karekök alma
result=Math.sqrt(25);
result=Math.sqrt(64);
// mutlak değer
result=Math.abs(-10);
 //max min bulma
result=Math.min(12, 48, 89, 5);
result=Math.max(12, 48, 86, 5);
// rastgele değerler üretme
result=Math.random();
result=Math.random()* 100;
result=parseInt(Math.random()*10)+1;




console.log(result, typeof result);