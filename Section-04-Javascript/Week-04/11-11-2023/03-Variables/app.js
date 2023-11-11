// "use strict"
//Değişken tanımlamak zorunlu olmasa dahi, biz tanımlamayı seçmeliyiz.2 tane vardır
// let: değişken kurallarına uygun bir isim (firstName)olmasını bekler tanımlama olduğunu anlar ne tür veri tipi var
// metinler tırnak içi sayılar tırnaksız yazıılır
// tip değiştirme yöntemi
// çift eşit ya da 3 eşit olunca farlı oluyor onu bir daha dne
// çoğu zaman değişkenleri böyle tanımlamayacağız


// log lamak birşeyi oaya yazmak anlamına gelir loger 
// console.log  uygulamayı geliştirmek için kullanılır.  özel alan gibi kullanılır

// let firstName;
// let lastName;
// let age;
// let department;
// let gender;
// let price;
// let kdv;
// let kdv2;

// firstName = "Halil";
// lastName= "uçar";
// age = "33";
// price = "100";
// kdv= 1.2;
// kdv2 = "1.2";


// console.log(firstName, lastName,age);
// console.log(price * kdv);


// if (kdv===kdv2) {
//     console.log("Değerler eşit")
    
// }
// else {
//     console.log("Değerler farklı")
// }

// let firstName = "Sezen";
// let age = 40;
// let isActive = true;


// console.log(firstName, age, isActive)
// bununla (bir yukarıdaki) tek seferde atama yapmış oluyoruz c# da da bunu kullanacağız tipi meselesiöenmli olan 
// typeof iki şekilde kullanılır  birden fazla kullanışlarda ikinci tip daha mantıklı .
// let sayi = 100;
// console.log(sayi,typeof sayi);
// console.log(sayi,typeof(sayi));

//  string tipi
// let firstName = "Deniz";
// console.log(firstName,typeof firstName)


// let width = 41.6;
// console.log(width, typeof width);

// null= bunun için de bir değer vardır boş olsa bile  ... aslında js için herşey bir object=nesne dir o.ortak özellik muhabbeti , herşey ondan türüyor. atası yani. js nesne yönetiliye destekler c# ise tam anlamıyla öyleidr.

//  let sayi = null;
//  console.log(sayi, typeof sayi);

// NaN= not a number :  (sanırım ) türünü verip  [nu kısıma tekrar bak]yapıp içine deger vermezsek bunun bir sayı olmadığını bize gösterir


// let sayi =  undefined
// console.log(sayi / 4);

// let sayi= 30;
// console.log(sayi/0);


// Infinitydir=sonsuzluk tur
//   1null 
//   2undefined değer ve tip
//   3Infinity

let sayi = Infinity;
console.log(sayi, typeof sayi);
// js sayılardan ibaret değilidr  infinity de olduğu gibi