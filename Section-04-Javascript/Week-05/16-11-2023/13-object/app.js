//Java Script Object Notation-JSON ; veri formatı taşıma tarif yapısı(uygulmalar arası hızlı şekilde iletişim sağlayan bir yapıya shiptir. ) dizilerle kullanacak json kuralları var dizlerin yazılış formatını biliyoruz zaten.dizyle kullanma yöntemi;
 //aynı haytla code arasıda bir bağ kurmamızı sağlayacak =object
// let students1=["Zeynep Nur","Ay",28,"kadın"];
// let students2=["Çağdaş","Taş",28,"erkek"];
// let students3=["Furkan","Gültekin",20,"erkek"];

// let students=[students1,students2,students3];
// console.log(students);  //consolda içinde 

// for(let i=0; i<students.length;i++){
//     console.log(students[i][0]+" "+students[i][2]);
// }
//  let student1={
//     firstName:"Zeynep Nur",
//     lastName:"Ay",
//     age:28,
//     gender:"Kadın"
//  };
 //yukarıdaki students1 değişkeni bir OBJECT'tir(nesnedir).firstName,lastName,age ve gender ise bu objenin özellikleridir.(property)

//  console.log(students1.firstName);
//  console.log(students1.gender+""+students1.age);

// let student2 = {
//     firstName: "Mehmet Emir",
//     lastName: "Sürmeli",
//     age: 21,
//     gender: "Erkek"
// };
// let student3 = {
//     firstName: "Didier",
//     lastName: "Drogba",
//     age: 45,
//     gender: "Erkek"
// };

 
//3 öğrencini firtname  gender alt alta

// console.log(students.firstName+" "+students.age)
 
// let students=[student1,student2,student3];
// let total=0;
// let studentCount=students.length;
// for(let i=0;i<students.length;i++){
//     console.log(students[i].firstName+" "+students[i].gender);
//     total += students[i].age;

// }
// let avarage=total/studentCount;
// console.log("Yaş ortalaması:"+avarage.toFixed(2));

//Soru ) içerisinde Ahmet Mehmet ve Yeşim değerlerinin olduğu bir dizi tanımlayaın,ayrıca yine içerisinde inşaat mühendisliği yazılıl mühendisliği ve mimarlık değerlerinin olduğu bir başka dizi tanımlayın.Sonra içinde name ve departmen bilgilerinin yer aldığı 3 adet student objesini şu şekilde oluşturun;
//3 öğrenciye rastgele bölüm atansın;ve örnek olarak şu şekilde nesnler oluşsun;
// {
//    name;"Ahmet",
//    department: "Yazılım Mühendisliği"
// }