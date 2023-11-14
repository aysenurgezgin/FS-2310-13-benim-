let courseName= "Fullstack Web Developer Eğitimi     ";
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

//şuradan itibaren demek virgülden sonrası  (3)ün olması

console.log(result)