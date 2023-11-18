//Dom=documant object model: seçme işlemi yapmaya başlayabileceğiz;hiyerarşik yapının sahibi gibi
//1)Sİngle Element=id si olan elemt

// let result;
//getElementById

// result=document.getElementById("task-list");
// result= document.getElementById("title");
// result.style.backgroundColor="red";
// result.style.color="white";
// result.style.padding="10px";
// // result.innerText="full stack programlama";
// result.innerHTML="<span style='coloryellow'>Full stack"

//querySelector
// result=document.querySelector("#title");
// result=document.querySelector(".card-title");
// result=document.querySelector("li");
//quarySelector,dokümanın en üstünden başlayarak ilk karşılaştığı
// elemenı bulup getirir


//2)Multi Elements
//getElemntsByClassName  elementleri getir
// let result;
// result =document.getElementsByClassName("card-title");
//birden azla element sağlıı
// result=document.querySelector("li");//birazdan tümünü seçecekqueri yaıcaz
// result=document.getElementsByClassName("task");
// result=document.getElementsByTagName("li");
//tag ile yaptık
//queryselctoe all ikisi de aynı işlemi yaptı
// result=document.querySelectorAll(".task");//farkı teknik
// result=document.querySelectorAll("#task-list-2 .task")

// console.log(result);
//araştırma ödevi: HTMLCollection ile NodeList arasındak fark?

//3)Traversing Elemnts

let result;
// let taskList=document.getElementById("task-list");
// result=taskList.children;
// console.log(taskList);

// let body=document.querySelector("body");

// console.log(body);
// result=body.children;
// result=body.children[3];
// result=body.firstElementChild;
// result=body.lastElementChild;
// result=document.getElementById("title");
// result=result.parentElement.parentElement.parentElement.parentElement;

result=document.getElementById("task-list");
// result=result.firstElementChild;//aynı seviyedeki ilk elementi seç
result=result.nextElementSibling.nextElementSibling;
result=result.previousElementSibling.previousElementSibling;
console.log(result);