// let fullName = ["Kemal", "Candan"];
// let firstName = fullName[0];
// let lastName = fullName[1];

// let [firstName, lastName, city] = fullName;
// console.log(firstName, lastName, city);

// let fullName = "Mustafa Kemal Atatürk";
// let [name1, name2, name3] = fullName.split(" ");
// console.log(name1);
// console.log(name2);
// console.log(name3);

// let userInfo = ["enginniyazi", "Engin Niyazi", "Ergül", 48, "İstanbul", "Türkiye"];
// let [userName, firstName, lastName, age, ...address] = userInfo;
// console.log(userName);
// console.log(firstName);
// console.log(lastName);
// console.log(age);
// console.log(address.join("/"));

const product = {
    productName: "Adidas",
    price: 2750,
    model: "Runner2023",
    color: "yellow"
}

// let { productName, price, model, color, size } = product;
// console.log(productName);
// console.log(price);
// console.log(model);
// console.log(color);
// console.log(size);

product.price = 4000;
console.log(product.price);
product.color = "blue";
console.log(product.color);
product.size = "XL";
console.log(product.size);  
