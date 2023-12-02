// 1- Store the following order information in object.
// 2- Calculate the total paid price, including KDV, for each order separately. (KDV: 18%)
// 3- Calculate the total paid price of all orders, including KDV.
let order1 = {
    orderId: 101,
    orderDate: "31.12.2022",
    odemeType: "kredi kartı",
    cargoAddress: "Yahya kaptan mah. Kocaeli İzmit",
    products: [
        { productId: 5, productTitle: "IPhone 13 Pro", productUrl: "http://abc.com/iphone-13-pro", productPrice: 22000 },
        { productId: 6, productTitle: "IPhone 13 Pro Max", productUrl: "http://abc.com/iphone-13-pro-max", urunFiyati: 25000 }
    ],
    costumer: { costumerId: 12 },
    seller: { companyId: 34, companyName: "Apple Türkiye" }
};

let order2 = {
    orderId: 102,
    orderDate: "30.12.2022",
    orderType: "kredi kartı",
    cargoAddress: "Yahya kaptan mah. Kocaeli İzmit",
    products: [
        { productId: 6, productTitle: "IPhone 13 Pro Max", productUrl: "http://abc.com/iphone-13-pro-max", productPrice: 25000 }
    ],
    costumer: { costumerId: 12 },
    seller: { companyIdId: 34, companyName: "Apple Türkiye" }
};


const kdvRate = 0.18;


function calculateTheFullAmountIncludingKdv(order) {
    let totalAmount;
    let kdvRatedvRate;
    let totalPrice  = order.products.reduce((total, product) => total + product.productPrice, 0);
    let totalAmountIncludingKdv =  + (totalAmount * kdvRatedvRate);
    return totalAmountIncludingKdv;
}

let orderTotalAmountIncludingKdv1 = calculateTheFullAmountIncludingKdv(order1);
let orderTotalAmountIncludingKdv2 = calculateTheFullAmountIncludingKdv(order2);

let totalAmountIncludingKdv = orderTotalAmountIncludingKdv1 + orderTotalAmountIncludingKdv2;

console.log("Order 1 total price including KDV: " + orderTotalAmountIncludingKdv1);
console.log("Order 2 total price including KDV: " + orderTotalAmountIncludingKdv2);
console.log("Total price of all orders including KDV: " + totalAmountIncludingKdv);