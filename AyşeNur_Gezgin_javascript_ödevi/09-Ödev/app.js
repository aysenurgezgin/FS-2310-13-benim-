//Creatae an array with the elements"Apple, Pear, Banana, Strawbery"
let fruitArray = ["Apple", "Pear", "Banana", "Strawbery"];


let stringLength = fruitArray.length;
console.log("How many elements does the array have? " + stringLength);

let firstElement = fruitArray[0];
let lastElement = fruitArray[stringLength - 1];
console.log("First element of array: " + firstElement);
console.log("Last element of array: " + lastElement);


let anyApple = fruitArray.includes("Apple");
console.log("Is apple an element of the array? " + anyApple);

fruitArray.push("cherry");
console.log("Array after adding cherries: " + fruitArray);

fruitArray.splice(stringLength - 2, 2);
console.log("Array after deleting last 2 elements: " + fruitArray);


let students = [
    { name: "Kemal Devrimdar", birthYear: 2010, notes: [70, 60, 80] },
    { name: "Saliha Temel", birthYear: 2012, notes: [80, 80, 90] },
    { name: "Defne Küp", birthYear: 2009, notes: [60, 60, 70] }
];

students.forEach(function (student) {
    let currentYear = new Date().getFullYear();
    student.age = currentYear - student.birthYear;
    student.gradeAverage = (student.notes.reduce((a, b) => a + b, 0)) / student.notes.length;
});

console.log("Students: ", students);