// let numbers =[4,9,14,20,19];
// let evenNumbers = numbers.map(nextNumber => {
//     if(nextNumber % 2 != 0)return nextNumber;
// }) ;
// console.log(numbers);consolda yazılan tüm numaralar
// console.log(evenNumbers);consolda tek sayılar yazılır çift sayılar undefined yazar

// Altta ki örneği yapmamzın sebebi undefined'lar kafanı karştırmasın diye ,koşula uyanı koy demeyiz bazen de hatta çoğu kez bu şekilde işlerimiz olur.

let prices = [40,50,100,200,250];
let newPrices=prices.map(nextPrice=>{
    return nextPrice*1.2;
})
console.log(prices);
console.log(newPrices);

// Aklında kalması gereken Map ile ilgili:Map yeni bir dizi oluşturuyor, yeni dizi veriyor ve üzeinde çalıştığımız dizimizin eleman sayısı kaçsa oluşan dizimizin de eleman sayısı o dur .