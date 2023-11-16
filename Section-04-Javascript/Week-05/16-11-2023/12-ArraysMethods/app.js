"use strict"; //değişkenlr
let students=["ayşen","umay","ceyda","begüm","köfte","heda"];

let result;
result = students.length;
result= students;//dizilerde olduğu gibi aynı çalışmıştır.
result=students.toString();
result=students.join(";");//aralara istenilen şey yazılır 
//  (herbir elemanın farklı bir değişkene atama split;)
// result=students.split(""); burad sıkıntı var;

let products1 =["ürün1","ürün2","ürün3"];
let products2 = ["ürün4", "ürün5", "ürün6"];

result=products1.concat(products2);// concat etmek birleştirmek

//EKLME YA da çıkarmak gereken durumlar belleğe atmak zorunda olduğumuz zamnalarda local story de tutulacaklar.dizi olarac çekmiş olacağız


// students.push("Zeynep");//push metodu diziye sonda eleman ekler.
// students.pop();//son elemanı siler (pop u kullnırsan son elamnı silerim ama en sonunucunda value dğer verir yani neyi sildiğini en sounda haber veriyor ama bize haber verme dedik?bu neydi?);
// students.shift();//ilk elemanı siler
// students.unshift("Ece");//Başa eleman ekler.(items olarak ece yi ekledik)
// students[1]="Haydar";//dizinin 1.elemandır. elemanın yerini değiştirme işlemi gerçekleşir


//students dizisindeki 'ceyda' değerini taşıyan elemanın içeriğini 'ece'olarak değiştirin  cvap=indexof ile bulunabilir  

// let indexCeyda=students.indexOf('ceyda');
// students[indexCeyda]="ece";  tek satırda yapılması;

// students[students.indexOf('ceyda')]="ece";

students.splice(students.indexOf("ceyda"),1);
students.splice(2);

//silenini döndürüyor (po) da (splice) aynı mantık.değişken kavramı her projede kullanılacak.







result=students;


console.log(result);
