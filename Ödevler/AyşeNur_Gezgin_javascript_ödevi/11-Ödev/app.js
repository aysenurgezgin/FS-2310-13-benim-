
let sayilar = [1, 5, 7, 15, 3, 25, 12, 24];
let kareler = sayilar.map(sayi => sayi * sayi);
console.log("1. Kareler: " + kareler);


let besinKatiSayilar = sayilar.filter(sayi => sayi % 5 === 0);
console.log("2. 5'in Katı Sayılar: " + besinKatiSayilar);


let ciftSayilarToplami = sayilar.filter(sayi => sayi % 2 === 0).reduce((toplam, sayi) => toplam + sayi, 0);
console.log("3. Çift Sayılar Toplamı: " + ciftSayilarToplami);


let urunler = ["iphone 12", "samsung s22", "iphone 13", "samsung s23", "samsung s20"];
let buyukHarfUrunler = urunler.map(urun => urun.toUpperCase());
console.log("4. Ürünler Büyük Harfle: " + buyukHarfUrunler);


let samsungUrunSayisi = urunler.filter(urun => urun.toLowerCase().includes("samsung")).length;
console.log("5. Samsung Ürün Sayısı: " + samsungUrunSayisi);


let ogrenciler = [
    { "ad": "yiğit", "soyad": "bilgi", "notlar": [60, 70, 60] },
    { "ad": "ada", "soyad": "bilgi", "notlar": [80, 70, 80] },
    { "ad": "çınar", "soyad": "turan", "notlar": [10, 20, 60] }
];

ogrenciler.forEach(ogrenci => {
    let notOrtalamasi = ogrenci.notlar.reduce((toplam, not) => toplam + not, 0) / ogrenci.notlar.length;
    let basariDurumu = notOrtalamasi >= 50 ? "Başarılı" : "Başarısız";
    console.log(`${ogrenci.ad} ${ogrenci.soyad} - Not Ortalaması: ${notOrtalamasi.toFixed(2)} - Başarı Durumu: ${basariDurumu}`);
});


let tumOgrenciNotOrtalamasi = ogrenciler.reduce((toplam, ogrenci) => toplam + ogrenci.notlar.reduce((a, b) => a + b, 0) / ogrenci.notlar.length, 0) / ogrenciler.length;
console.log("7. Tüm Öğrencilerin Not Ortalaması: " + tumOgrenciNotOrtalamasi.toFixed(2));