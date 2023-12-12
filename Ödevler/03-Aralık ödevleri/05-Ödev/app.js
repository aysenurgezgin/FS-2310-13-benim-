var dogruSayi = Math.floor(Math.random() * 100) + 1;

var hak = 5;
var puan = 100;

function tahmin() {
    var tahminInput = document.getElementById("tahminInput");
    var tahmin = parseInt(tahminInput.value);

    if (isNaN(tahmin)) {
        alert("Geçerli bir sayı girin.");
        return;
    }

    hak--;

    if (tahmin === dogruSayi) {
        document.getElementById("durum").innerHTML = "Tebrikler! Doğru sayıyı buldunuz.";
        document.getElementById("puan").innerHTML = "Toplam Puan: " + puan;
        disableInputButton();
    } else {
        if (hak === 0) {
            document.getElementById("durum").innerHTML = "Hakkınız bitti. Doğru sayı: " + dogruSayi;
            disableInputButton();
        } else {
            document.getElementById("durum").innerHTML = "Hatalı tahmin. Kalan Hak: " + hak;
            puan -= 20;
            document.getElementById("puan").innerHTML = "Toplam Puan: " + puan;
        }
    }
}

function disableInputButton() {
    document.getElementById("tahminInput").disabled = true;
    document.querySelector("button").disabled = true;
}