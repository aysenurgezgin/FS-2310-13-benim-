// 3)Code that prints the entered number and prime numbers up to 2
let n = prompt("Enter a number:");


function isItPrime(number) {
    if (number <= 1) return false;

    for (let i = 2; i <= Math.sqrt(number); i++) {
        if (number % i === 0) return false;
    }

    return true;
}


function findPrimeNumbers(n) {
    let primeNumbers = [];

    for (let i = 2; i <= n; i++) {
        if (isItPrime(i)) {
            primeNumbers.push(i);
        }
    }

    return primeNumbers;
}


let conclusion = findPrimeNumbers(n);


console.log(` Code that prints the entered number${n} and prime numbers up to 2 ${conclusion}`);