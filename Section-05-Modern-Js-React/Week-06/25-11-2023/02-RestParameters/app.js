const calculateCircleArea = (r, pi = 3) => {
    return "Circle Area :" + r * r * pi;
}
// console.log(calculateCircleArea(5, 3.14));
// console.log(calculateCircleArea(5));
// console.log(calculateCircleArea(5,3.145683));

const calculateCircleArea2 = (...parameters) => {
    let array = [...parameters];
    let r = array[0];
    let pi = array[1] == undefined ? 3 : array[1];
    return "Circle Area :" + r * r * pi;
}

// console.log(calculateCircleArea2(5, 3.14));

// Soru: içerisine gönderilen sayıları toplayıp, sonucu ekrana yazan arrow functionı hazırlayalım.
const getTotal = (...numbers) => {
    console.log([...numbers]);
    let numbersArray = [...numbers];
    let total = 0;
    for (let i = 0; i < numbersArray.length; i++) {
        total += numbersArray[i];
    }
    return total;
}

const basketItemsPrices = [135, 500, 900, 250];
console.log(getTotal(...basketItemsPrices));
// console.log(getTotal(5, 6, 55, 66, 44, 22, 64, 65));