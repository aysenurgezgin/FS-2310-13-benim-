//10'dan büyük olan sayıları consola yazdıran kod;ilk yazdığımız kod map number uygulamasının yazım şekli;ikincisi Filer kullanarak yazmış olduğumuz kod.Yazdığımız şey map'den farklı değil (syntax olarak) sacede sonucu farklı olacak yani kullanım biçimi aynı bir farkla return den sonra true yazdım (consolda 3 elemanlı bir dizi oluşturdu ;koşula uyanlar)
//ikisi arasındaki farklardan biri de Map'de return yanın a ne yazdırırsan ben onu yazarım diyor(true'sa true sayı ise sayı döndürürüm,sıradaki elamanın içinne onu yazdırırım)Ama filter ben senden sıradaki sayının değerini falan istemiyorum bana bu değerin içeriye yaılıp yazılmayacağını söyle sadece diyor(yeni diziye atılıp atılınmayacağını=push edeyim mi yani diye soruyor aslında)
let numbers =[4,9,14,20,19];
let newNumbers =numbers.map(nextNumber=>{
    if (nextNumber >= 10)return nextNumber;
});
console.log(numbers);
console.log(newNumbers);

// let newNumbersFilters = numbers.filter(nextNumber=>{
//     if (nextNumber<= 10) return true;
// });
// console.log(newNumbersFilters); //(ardakada)algoritmasında tru'sa bu şekilde yapayım false şöyle değil true ise ben sadece yazarım diyor.

// Üst kısımda ki nin kısa yazım şekli,bildiğin birşey aslında ama burada biraz filter fonksiyonuylada birleşerek bir tık daha kolaylaştırılmış şekli ortaya çıkıyor ;uzun bir kodla bunu yapamazsın üst kısımda olduğu gibi tek satırlık bir durum varsa tek komutluk aşağıdaki kullanım şekli ile kullanılabilir. Zaten tek return yazıyorsak return yazmadan bu şekilde yazabiliyorduk arrow fonk'larda ama  aynı zamanda arrow fon'tan sonra koşulda yazmamıza gerek bırakmıyor(yani if yazmamana gerek yok diyor)özellikle react tarafında çok kullanılan bir yazım şeklidir.

let newNumbersFilters = numbers.filter(nextNumber=>nextNumber>=15);
console.log(newNumbersFilters);