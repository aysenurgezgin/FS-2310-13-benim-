export const getResult = () => {
    let number;
    const allNumbers = [];
    const oddNumbers = [];
    const evenNumbers = [];
    for (let i = 0; i < 10; i++) {
        number = Math.ceil(Math.random() * 100);
        allNumbers.push(number);
        if (number % 2 == 0) {
            evenNumbers.push(number);
        } else {
            oddNumbers.push(number);
        };
    };
    let result = {
        all: allNumbers,
        odds: oddNumbers,
        evens: evenNumbers
    };
    return result;
}


export const randomNumbers = () => {

    return result;
}

export const getOddNumbers = (numbers) => {
    const result = [];
    for (const i in numbers) {
        // if (numbers[i] % 2 == 0) result.push(numbers[i]);
        if (numbers[i] % 2 != 0) {
            result.push(numbers[i]);
        };
    }
    return result;
}

export const getEvenNumbers = (numbers) => {
    const result = [];
    for (const nextNumber of numbers) {
        if (nextNumber % 2 == 0) {
            result.push(nextNumber);
        }
    }
    return result;
}
















// export const randomNumbers = () => {
//     const result = [];
//     for (let i = 0; i < 10; i++) {
//         result.push(Math.ceil(Math.random() * 100));
//     }
//     return result;
// }

// export const getOddNumbers = (numbers) => {
//     const result = [];
//     for (const i in numbers) {
//         // if (numbers[i] % 2 == 0) result.push(numbers[i]);
//         if (numbers[i] % 2 != 0) {
//             result.push(numbers[i]);
//         };
//     }
//     return result;
// }

// export const getEvenNumbers = (numbers) => {
//     const result = [];
//     for (const nextNumber of numbers) {
//         if (nextNumber % 2 == 0) {
//             result.push(nextNumber);
//         }
//     }
//     return result;
// }