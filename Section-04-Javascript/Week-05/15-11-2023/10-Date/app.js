// ne string ne sayıdır, yazımsal olarak ayrı oldugu içiçn ayrı () server ne olduğunu bil) çalıştığı yere göre sonuç çıkarır
let result;
let now;
now= new Date();
result=now;
result=now.getDate();//haftanın kaçıcı günü olduğunu belirtir
result=now.getDay();

// let newDate=new Date(2023,5,18); // 0 olmasının nedeni tam belli değil
// console.log(newDate);
// result=newDate.getDay(); // bunu tekrar bak


result=now.getFullYear();
result=now.getHours();
result=now.getTime();// 1900den beri milisaniye( 0 sn tam olarak ne oluyor) aritmatik yapabilme şansı oluyor

result=new Date(1900, 0, 10,30,0);
let year= result.getFullYear()+1;
let month=now.getMonth();
let day=now.getDate();
// result=now Date(year,mont,day);
//


// result= new Date(year)
// console.log(month);

// kaç gün yaşadığımızı bulan kod;

let birthday= new Date(1999,3,7);
let milisecond =now - birthday;
let second=milisecond/1000;
let minute=second/60;
let hour=minute/60;
let dayCount=hour/24;

console.log(dayCount);
console.error(dayCount);
console.warn(dayCount)
//consola yanlış olduğunu göstermek amaç hata gibi davranmasını sağlar.hata olduğunu ya da uyarı vermesi için kullanılır.

//Araştırma ödevi:getTime()'ı 0 olan tarih nedir?

