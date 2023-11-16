// let a=50;
// if(a>10){
//     console.log("Sayı büyük.")
// };


// let a=5;
// if(a>10){
//     console.log("Sayı büyük.");
// } else{
//     console.log("sayı büyük değil.");
// }

// let a= 5;
// if(a>10){
//     console.log("Sayı büyük");
// }
//  else if(a<10){
//     console.log("Sayı küçük");
// }
// else{
//     console.log("Sayılar eşit");
// }


// let a=5;
// if(a>10){
//     console.log("Büyük");
// }
// if(a<10){
//     console.log("Küçük");
// }
// if(a==10){
//     console.log("Eşit");
// }

/* 
    0-16:Çocuk;
    17-35: Genç;
    36-50: Yaşlı;
    51-70: Ölmüş ağlayanı yok;
    71'deb büyükse: No comment

*/ 
// let age=90;
// if(age <= 16){
//     console.log("Çocuk");
// }
// else if(age <= 35){
//     console.log("Genç");
// }
// else if(age <= 50){
//     console.log("Yaşlı");
// }

// else if(age <= 70){
//     console.log("ÖLmüş ağlayanı yok");
// }
// else {
//     console.log("No comment");
// }

//  ( aaa)let age=90;
// if(age <= 16){
//     console.log("Çocuk");
// }
// if(age <= 35){
//     console.log("Genç");
// }
// if(age <= 50){
//     console.log("Yaşlı");
// }

// if(age > 70){
//     console.log("ÖLmüş ağlayanı yok");
// }
// if{
//     console.log("No comment");
// }  bunu tam olarak nedne yaptık




// Ternary if oparetor(Üçlü operetör);

// let message;
// let age=50;
// if(age>=18){
//     message="girebilirsiniz";
// }
// else{
//     message="giremezsiniz";
// }
// message=age>=18? "girebilirsiniz.":"giremezsiniz";
// console.log("Yaşınız "+age +" olduğu için " + message);



/*
    0-16: Çocuk
    17-35: Genç
    36-50: Yaşlı
    51-70: Ölmüş ağlayanı yok
    71'den büyükse: No comment
*/

//Ternary if çözümü;

// let age=50;
// let result;
// result= age <= 16 ? "Çocuk":
//         age <= 35 ? "Genç":
//         age <= 50 ? "Ölmüş ağlayanı yok":"no comment";
//         console.log(result);


// alert= js kullanılarak oluşturulan ve genllikle kullanıcıya bir hata hakkında uyarı
// vermek için ya da öneride bulunmak için otomatik açılan pop-up penceresidir.

// alert("Merhaba");
// yukarıda ki daha pratik yazılmış olanı
// let message= "Merhaba";
// alert(message);


// prompt():kullanıcıya soru sorup klavyeden girilen bilgiyle işlem yapan,o bilgiyi döndüren bir
// window metodudur.alert()gibi html üzerinde, html sayfasından bağımsız çalışır ve karşımıza diyalog
// penceresi şeklinde çıkar.

// confirm();bu metod birer onay ve iptal metodu sunar,bu sayede kullanıcıya bir sonraki işlem için onayı
// olup olmadığını veya bir sonraki işlemi yapmak istediğinden emin olup olmadığını sormak içindir.


// let age;
// age =prompt("Kaç yaşındasınız?")
// console.log(age+" yaşındasınız.")
// console.log(typeof age);

// result= confirm("Emin misiniz?");

// bu kısım?

//Soru-1)

// let a =40;
// let b=60;
// let result;
// if(a-b<30){
//     result="Küçük";
// }
// else{
//     result="Büyük";
// }  
//Yukarıda ki kodu Ternary if kullanarak yazın.

//Cevap;

// let a = 110;
// let b= 60;
// let result=a-b<30? "küçük":"büyük";
// console.log(result);

//Kullanıcıya "JavaScript'in offical ismi nedir?"şeklinde bir soru sorup,gelen cevap"ECMAScript"ise "Tebrikler,bildiniz!",değil ise"Yanlıs yeniden"şeklide bir cevabı alert ile veren kod;
// a) if ..else ile 
// b) ternary if ile yazınız.

let correctAnswer="ECMAScript";
let userAnswer=prompt("Javascript'in offical ismi nedir?");
let result;
// if(userAnswer==correctAnswer){
//     result="Tebrikler,bildiniz";
// }
// else{
//     result="Yanlış,tekrar";
// }
//tam çalışmadı

//b)

result=userAnswer==correctAnswer? "Tebriks":"yeto";
alert(result);