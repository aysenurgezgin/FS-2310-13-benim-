//myModels2 klasörü için de myModules  diye bir klasör oluşturup içinde de  dosya oluşturduk; bu dosya da dizileri sıralamaya yarayan bir kodumuz olacak içinde.
//a) index. html ye git
//c) tabi ki bunu yaptıktan sonra app.js te çekmeye başlayabiliriz ama daha birşey yazmadık;
// js'te dizilerin sıralanmsıyla ilgili özel hiç birşey yapmadık,dizilerle ilgili metodları gördük ama sıralama yapmadık;ilk olarak internette sort fonk araştır;
//sort fonk'da sayıların sıralanmasında sıkıntı var;string e dönüştürerek sıralamaya çalışıyor ve js geliştiricileri bilerek unu bizim algoritma üreterek bu sıkıntıyı ortadan kaldırmamızı bekliyor;

//d) sort-array isimli fonk bize şuan da bir senaryo versin;bizim öncelikle rastgele sayılar üretip bir dizinin içerisine atmamız gibi bir durumumuz olsun,biz ne zaman çağırırsak rastgele dizi üretelim
// de onu sıralasın; her defasında yeni değerler girelim falan diyip testtimizi zorlaştırmak değil;

// ilk iş rastgele sayılar üreten fonk oluşturmak;number dememizin sebebi=birden fazla sayı üreteicez ama biryerden bunu çağıracağımızı düşün 1den 100e kadar döngünün içinde bunu çağıracağız işte.=()içine bir 
//değer alsın diyoruz; random fonk çalışma mantığıyla(0ile 1 arasında çalışıyordu)ben onu oarada her kullanıcağım zaman bu hesapla uğraşmak istemiyorum o yüzden kendime rastgele sayı üreten fonk yazıcam: ben 
//sana üst sınırı vereyim sen bana sıfırla o üst sınır arasında sayı üret dediğim bir fonk; tek return olduğu için (arrow fonk hatırla)okun yanına hemen matematiksel sınıftan floor'u bir al sonra(Math.random()*maxNumber)ile
//rastgele sayıyı üret ve bunu maxNumber iile çarp ama 0 ı istemediğim için +1 de ve maxNumber'ı da dahil etmek için maxNumber'ın yanına da +1ekle ve parantez içine al o kısımla beraber;


//0-maxNumber arasında rastgele sayı üretir.
const randomNumber =maxNumber=> Math.floor(Math.random()*(maxNumber+1));

//normal sort yapalım; (aslında tek fonk lada yapılabilirdi)iki fonk ayrı ayrı yazıcaz.ASC küçükten büyüye sıralamayı yapıcak olan fonk;dışarıdan bi dizi alacak o yüzden parantez içinde yazmaya gerek yok
//e) Bunu dışarı açabilmek için başına export yazdık; ve app.js kısmına geç

//g) app.jste baş kısmı;fonk üst kısmına konuşlanıp y da alt kısmına buraya kafadan export edeceğimizi düşündüğümüz bir fonk haırlayalım.Dizi oluşturmak için ismi;getArray
//eşittir count diyip bir resultArray tanımlayıp başlangıçta bir dizi olusturuyorum, iç kımına fordöngüsü yaptık eleman sayısına da count,un alt kısmına sen her yeni sayı üretmek için dönmek için result un içine şunu ata eklemek için pushiçine randomNumber içine 1 ile 100 arasında bir sayı üretecek şekilde ürettiğin değeri al getir


export const arrayASC= array=>{
    return array.sort();
}
//g) nin fonk;
export const getArray= count =>{
    const resultArray=[];
    for(let i=0; i<count; i++){
        resultArray.push(randomNumber(100));
    }
    return resultArray;
}

// appjs te takrar yazmıyoruz arrayasc nin yanına ekliycez
//ğ) app.js e git ikinci fonk ekle.











//Değişken tanımlar gibi fonk yazdık.ies6 'yla beraber gelen fonk'ların yararlerından bitanesi bu.Ama bunu normal bir fonk olarak yazalım;
//fonk halinde yazımı;

// function randomNumberOld(maxNumber){
//     return Math.floor(Math.random()*(maxNumber+1)+1;
// }  yukarıda yazılanla aynı şey demek işte
