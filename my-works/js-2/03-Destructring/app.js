// ne olduğunu bildiklerimizi js bazı özelliklerini  hatırlayarak bakalım.
// elimizde böyle bir dizi var ve bu dizinin içinde 1. eleman kemal 2.elaman candan bu isim ve soy isme uygulama için de sık sık ihtiyaç duyduğumuz için onlara ayrı birer değişkende tutalım istiyoruz

// let fullName = ["Kemal","Candan"];
// bu kısımda city yaınca consolda bu ksım allati let tanımlayıcısıyla uymadığı için umursamadı
// alttaki iki satır ilk denemeden kalma
// let firsName = fullName[0];
// let lastName = fullName[1]; 
// bu işlemin alternatifi yazan yer yani uzun oldugu için alternatif kullanıcaz

// bu işlemin alternatifi; [kendi kendini indexte tutuyor] diziler de kullanım şekli bu destructring in
// let  [firsName,lastName,city]= fullName;
// console.log(firsName,lastName,city)
// city =undefined olarak gözükür consolda

// a)
// let fullName="ayse nur ge";
// let [name1, name2, name3]=fullName.split(" ");
// console.log(name1);
// console.log(name2);
// console.log(name3);

//split yapmadan niye? dizi ya aslında 1. eleman a 2.eleman y burada o yüzden split(splitle ayırdık) yaptık stringlerde-strinhg olan bir değişkende de des.. işemini uygulayabilirzi

// b)objelerle kullanma şekli;elimiz de product olarak bir değiiken var bunun bilgileri var elimizde tabiki product'ı bir dizi olarak tutabiliriz dizileri konuşurken yaptık örneklerde ama bunu obje olarak daha mantıklı olur demiştik;skop içinde 
// sıra önmli değil bu ksımda en sonda bile baştakini çağırabilirim
// objenin özwl bir 
let product = {
    productName :"Adidas";
    price : 2750;
    model : "Runner2023";
    color: "yellow";
}
// bu alttaki işlemin amacı productName ,le adidas' eşitledin diyor,olmayan bir property'i alt kısımda almaya çaışırsak;size yok altta var gibi davranırsak consolda undefined yazdırır=
// let {productName,price,model,color,size} = product;
// console.log(productName);
// console.log(price);
// console.log(model);
// console.log(color);
// console.log(size);

// şu şekilde de çağırma işlemini yapabilirm; yukarıda olduğu gibi objeyle bu destr.., işlemini gerçekleştiriyorsam obje parantezim olan süslü parantezi kullanmam yeterli

console.log(product.price);
// farklı bir değer atamak olan şeye;
product.price=4000;


