//Perform the following steps using the given URL and course name information.
// url="https://www.wissenakademie.com&quot;;
// lessonName="Fullstack Web Developer Training";
// -How many characters does the url have?
// -How many words does the course name consist of?
// -does the url start with https?
// -Does the word Education appear in the course name?
// Create the following string expression using -url and course name:
// https://www.wissenakademie.com/fullstack-web-gelistirme-egitimi

let url="https://www.wissenakademie.com";
let courseName= "Fullstack Web Developer Eğitimi";
let urlNumberOfCharacters=url.length;
console.log("Url number of characters: "+urlNumberOfCharacters);
let courseNameWordCount= courseName.split(" ").length;
console.log("course name word characters: "+courseNameWordCount);
let urlStartCheck= courseName.startsWith("https");
console.log("Does the URL start with https?"+urlStartCheck);
let eğitimCheck=courseName.includes("Eğitimi");
console.log("Does the course name include Eğitim?"+eğitimCheck);
let newStringExpression=url+"/"+courseName.toLocaleLowerCase().replace();
console.log("New String expression: "+newStringExpression);