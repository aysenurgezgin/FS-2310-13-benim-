let courseName= "Fullstack Web Developer Eğitimi";
let result;
 result= courseName.toLocaleLowerCase();
 result= courseName.toLowerCase();
 result= courseName.toUpperCase();
 result= courseName.toLocaleUpperCase();


 result= courseName.length; //Property-Özellik
 //  sıra numaraları 0 dan başlar  ! slice kadar 
//  parametre
 result=courseName[0];
 result=courseName[125];
result = courseName.slice(0,2);
 result=courseName.slice(14,23);

 result=courseName.replace("Eğitimi","Kursu");
 result=courseName.replace("a","e");
result=courseName.trim();

result=courseName.trimStart();
result=courseName.trimEnd();


result=courseName.indexOf("F",3);
//şuradan itibaren demek virgülden sonrası  (3)ün olması 0 yazmasamda baştan başla anlamına gelir  (split=ayırmak) dizi meselesi 4 tane sözcük tek tek kelimelere ayırmak için("") kelime ayırmak için(" ") bir boş bırak yani  (strinler = metinler) algoritma kurmayı öğrnemek
result=courseName.split("");

result=courseName.startsWith("F");// bolean tarzda bir cevap verir
result=courseName.endsWith("i");



console.log(result);

//indexOf ile ilgili minnak bir örnek;
// let message;
// let findedText;
// message=prompt("Lütfen metni giriniz:");
// findedText=prompt("Lütfen arayacağınız metni ya da karakteri giriniz.");
// result=message.indexOf(findedText);
// if (result== -1) {
//     alert(message+"içinde"+ findedText+"bulunamaıştır.");

// }
// else{
//     alert("'" + message+ "'"+" içinde "+"'"+ findedText+"'"+(result+ 1) +".sırada bulunmaktadır.");
//     result meslesine tekrar bak!
// }


