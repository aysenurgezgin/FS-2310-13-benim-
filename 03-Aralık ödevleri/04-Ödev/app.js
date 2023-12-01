// // Find out whether an entered year value(for example:1975)is a leap year and print the result to the console.A year is a leap year if it is divisible by 400 or even by 4 but not by 100.

let year = prompt("Please enter a year:");

if (isNaN(year)) {
    console.log("You did not enter a valid year value.");
} else {
    if ((year % 400 === 0) || ((year % 4 === 0) && (year % 100 !== 0))) {
        console.log(year + "is a leap year. ");
    } else {
        console.log(year + "is not a leap year. ");
    }
}