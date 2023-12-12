let counterValue =0;

const counterElement = document.getElementById("counter");

function artanCounter(){
    counterValue++;
    updateCounter();
}
function sıfırlayanCounter(){
    counterValue=0;
    updateCounter();
}
function azalanCounter(){
    counterValue--;
    updateCounter();
}
function updateCounter() {
    counterElement.textContent =counterValue;
}