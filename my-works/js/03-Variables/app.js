// "use strick"
// Değişken tanımlamak zorunlu olmasa dahi,biz tanımlamayı seçmeliyiz
//  let firstName="s"
//  let lastName="halil";

//  console.log(firstName);
// console.log(lastName);

// 77firstName ="Halil";
// lastName = "Uçar";
// age = "33";
// price = "100";
// kdv= 1.2;
// kdv2="1.20";
 
// console.log(firstName,lastName, age);
// console.log(price*kdv);
 
// if(kdv==kdv2){
//     console.log("değerler eşit");
// }
// else{
//     console.log("değerler farklı");
// }

// === anlamı; iki değerin hem tipini hem de değerini;== ise değerlerlerin
// yiplerini eşitleyerek sadece değer karşılaştırması yapar.



// let firstName="Sezen";
// let age= 48;
// let isActive = true;
// console.log(firstName,age,isActive);

// let isActive = false;
// console.log(isActive);
// boolean türündeki bir veri tipi true ya da false bir değer alır ör:isActive
// ismindeki boolean değişkeni içine false değeri atadık ve typeof operatörü ile 
// bakarsak boolean tipinde olduğunu görürüz.;kullanmamızın sebebi durumun doğru ya da yanlış olduğu bilgisni tutmak içindir.



// Veri Tipleri 

// let sayi="100";
// console.log(sayi,typeof sayi);
// console.log(sayi,typeof(sayi));

//string veri tipi karakter dizisidir.tek tırnak ya  da çift tırnak
// undefined; tanımlanan ancak içerisine değer atılmayan tipler içindir.



// let firstName="Deniz";
// console.log(firstName, typeof firstName);

// consola yazılan şey "Deniz string" cünkü clg ye yazılan değişkenin yanına
// yazılan typof değerin türünü de göstermemizi istemiştir.

// let width= 41.6;
// console.log(width,typeof width)

// consolda yazan şey "41.6 'number' "dır.


// let sayi= "null";
// console.log(sayi,typeof sayi);

//consolda yazan şey "null string"dir.null=hiçbir değeri temsil etmeyen değerdir.



// let sayi= undefined;
// console.log(sayi/4);

// consolda yazan şey "NaN"=Not a Number;satısal bir değeri olmayan bir değerle işlem 
//yaplılırsa js NaN sonucunu verir.


// let sayi=30;
// console.log(sayi/0);

//consolda yazan şey"Infinity";sonsuzluk -sınır değerini ifade etmek için Infinity veya
//Infinity anahtar kelimesi kullanılır.


let sayi= Infinity;
console.log(sayi,typeof sayi);

// consolda yazan şey "Infinity 'number' "dır.