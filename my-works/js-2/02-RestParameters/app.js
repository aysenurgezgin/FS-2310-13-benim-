// ben pi yi göndermeszem 3 olsun demiş oluyorum,bir string döndürelim dedik,çarpma işlemini yaprken pow u da kullanabilirsin 
 const calculateCircileArea=(r,pi=3)=>{
    return "Circle Area :" + r*r*pi;
 }
//   bu kısım varsayılan değer verme fonk
//  console.log(calculateCircileArea(5,3.14));
//  console.log(calculateCircileArea(5));
//  console.log(calculateCircileArea(5,3.145683));

// a) konumuza başlığı olan Rest parameters bu kısımda anlatımına başlıyoruz;
// skop içine her ne gönderirsek alacak ister bir tane ister 8 ya da 150 gönder hepsini ([...parametrs])paramter içine alacak,nasıl kullacak;
// köşeli parantez iiçnde aldğımız için consolda dizi şeklinde bri sonuç alıcaz =(2)[5,3.14] ve bir ok var ona tıklayınca tek tek özelliklerini belirtir.
//  const calculateCircileArea2=(...parameters)=>{
//     console.log([...parameters]);
//  }
//  calculateCircileArea2(5,3.14);

// b)clg yazmayalım da bunu değişkenlerin içine alalım şuan da(üstte) ... gibi birşey tanımlamak zorundayım ismi rest parameters olan,bir dizi tanımlayalım let ile
// ve bu lest parameters ı buraya nasıl aldımizi görmek için clg ye yazdığımız gibi let array= [...parameters] şimdi istediğimiz gibi kullanabileceğimiz let array imiz var
// calculateCircileArea ya gönderirken yarıçapı göndermek istiyorum sonra pi yield;bir depişken daha tanımlıyoruz let r ,let pi diye iki
const calculateCircileArea2=(...parameters)=>{
   let array =[...parameters];
   let r= array[0];
   let pi=array[1]==undefined ? 3 : array[1];
   return "Circle Area:"+ r*r*pi;
 }
// console.log(calculateCircileArea2(5,3,14));
//  c)varsayılanla daha kolay yazabilidğim  fonk rest parametres ile daha zor yazdık ama asıl konu ben bu rest parametrs ı nerede kullanabilirm?

// soru? içerisine gönderilen sayıları toplayıp,sonucu ekrana yazdıaran arrow fonk hazırla
// açıklaması; sayılar geleceği için numbers dedik,for döngüsünde i'yi 0 almamızın sebebi elimde bir dizi var dizinin de ilk elemanın index'0 0 dan başla demiş olduk,iküçük olduğu müddetçe neyden array'in(total) length'inden.iki numbers
// da birbirinden farklı biri rest parameters biri (let numbersArray)klasik değişken.akabinde de i'nin değerini her defasında bir arttıracağımızı söylüyoruz bundan sonrada toplamak çok kolay;total+= sıradaki numbers dzisinin elemamı yani[i];ve 
// nihayetinde bulmuş olduğum total' for döngüsünün akabinde ama fonk skobunun içinde geri döndüreyim "return  total "ile.Skobun dışına çıkıp clg ile içine(getTotal(itnilen sayılar virgül ile ayırmak suretiyle)) yazdıktan sonra consoldan kontrol et.


// ne gönderdiğin önmli değil için o toplar
const getTotal=(...numbers)=>{
    let numbersArray=[...numbers];
    let total=0;
    for (let i=0; i<numbersArray.length; i++){
        total+=numbers[i];
    }
    return total;
}
console.log(getTotal(5,7,7,4,90));

//bir tane de market örneği vardı onda da belirli fiyatlar vardı onları toplama onu da yap onun da ipucu let tamımlayıcının ön kısmına rest parameters olduğu için (...) unutma