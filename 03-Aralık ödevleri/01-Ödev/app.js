// 1)Get a second value from the user via prompt. For example, 1500. Then calculate how many minutes and seconds this entered value is and print it properly on the console.

let seconds= prompt("Enter a value in seconds ");

let minutes= Math.floor(seconds/60);
let remainingSeconds= seconds %60 ;

console.log("Entered value "+seconds);
console.log("Result: "+minutes+" minutes"+remainingSeconds+" seconds");