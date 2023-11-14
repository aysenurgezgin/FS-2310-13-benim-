//döngü= aynı kod parçasının tekrar tekrr çalıştırılmasını sağlayan yapıdır
//while
// let a =1;
// while () {
//     console.log(a)
// }

// let i=1;
// let sayac=0;
// while( i<=50){
//     if( i%4==0){



//     } else{

//     }
// }
// console.log(sayac);


// let i= 1;
// let counter =0;
// while (i <=50){
//     if ( i% 4== 0){
//           counter++;
//   i++
//     }

// }
//  console.log("1-50 arasındaki 4'ün katları olan sayı adedi:" counter):  nden tam olmadı bunu bir daha dene

//Gİrilecek 3 adet sayıyı toplayıp konsala yazdırın:

// let i = 1;
// let num;
// let total = 0;

// while (i <= 3) {
//     num = Number(prompt("Lütfen sayıyı giriniz"));
//     // total= total+ num   alttakiyle aynı şey;
//     total += num;
//     i++;

// }
// console.log(total);   consolda açmadın!!


// Kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp konsola yazan kodu yazınınız. Not: Kullanıcı 0 girerse uygulama sona ersin.

// 4



// Kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp konsola yazan kodu yazınınız. Not: Kullanıcı Exit yazarsa  uygulama sona ersin.
// let i=1;
// let total=0;
// let num;

// while(true){
//     num=prompt("Lütfen" +i+".sayıyı giriniz: (Çıkmak için'Exit')");
//     if(num.toLocaleLowerCase()=="exit"){
//         break;
//     }
//     total+=Number(num);
//     i++;
// }
// console.log("Total:"+total);



// let i = 0;
// let total = 0;
// let num;

// while (true) {
//     num = prompt("Lütfen" + i + ". sayıyı giriniz: (Çıkmak için'Exit')");
//     if (num.toLocaleLowerCase() == "12") {
//         break;
//     }
//     total += Number(num);
//     i++;
//  else(i>){

//  }

// }
// console.log("Total:" + total);

// let count= Number(prompt("Lütfen bir sayı gir"));
// for(let i =1; i<= count; i++){
//     console.log(i);
// }


//1 ile 10 arasındaki çift sayıları konsola yazdır;

// for(let=i; i<=10; i++){
//     if(i%2==0){
//         console.log(i);
//     }
// }


//1 ile 10 arasındaki tek sayıları bul  (+ contiune devam et komutunu yeni ekledik)

// for(let i=1; i<=10; i++){
//     if(i % 2==0) {
//         continue;
//     }
//     console.log(i);

// }

// Kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp konsola yazan kodu yazınınız. Not: Kullanıcı Exit yazarsa  uygulama sona ersin. not1=for kullan.
// let total=0;
// let num;
// for(let i=0; i==0;){
//     num =promt("Lütfen bir sayı giriniz:");
//     if(num.toLocalelLowerCase()=="exit"){
//         break;
//     }
//     total+= Number(num);
// }
// console.log(total);
 /* 
    1-20 arasındaki sayıları konsola şu şekilde yazdıran kodu hazırla
    1-tek Sayı
    2-Çift sayı
    3-Tek sayı
    ..
    ...
   
 */


for (let i = 1; i <= 20; i++){
    if(i%2==0){
        console.log(i+"- Çift sayı");
    }
    else(){
        console.log(i+ Tek sayı);
    }
}