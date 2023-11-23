const display = document.querySelector(".calculator-input");
const keys = document.querySelector(".calculator-keys");

let displayValue="0";
// her yerde kullacağım için bunu bu kısımda değişken atadık(aşağıdaki)
let waitingForSecondValue= false;  
// sen normal çalışıyorsun demek üstteki
let previousValue= null;
// yakalama icinn yazılan
let operator=null;
// içinde tutacağımız 


function updateDisplay(){
    display.value=displayValue;
}

keys.addEventListener("click",function(e){
    const element=e.target;
    const value=element.value;
    if(!element.matches("button")) return;
    switch (value) {
        case "+":
        case "-":
        case"*":
        case"/":
        case"=":
            handleOperator(value);
            break;
        case".":
            inputDecimal();
            break;
        case"clear":
            clearDisplay();
            break;

        default:
            inputNumber(value);
            break;
    }
    updateDisplay();
});


// ilk olarak sayı girişini atayacağımız için burada başladık
function handleOperator(nextOperator){
    let value=parseFloat(displayValue);
    
    if(operator==null && waitingForSecondValue==true){
        operator=nextOperator;
   
        return;
    }
    // eşittire bastığımız zaman bu kısımda olmasını bekliyoruz
    if(previousValue==null){
        previousValue=value;
    }else{
      const result=  calculate(previousValue, operator, value);
     displayValue=result.toString();
     previousValue=result;
    }
    operator=nextOperator;
    waitingForSecondValue=true;
};
function calculate(firstNumber, op, secondNumber){
    // küçük kod yazmam gerktiğinde switc için op u kontrol etmek için
    // console.log("operator",operator)
    switch(op){
        case"+":
        return firstNumber+secondNumber;
        case "-":
            return firstNumber - secondNumber;
        case "*":
            return firstNumber * secondNumber;
        case "/":
            return firstNumber / secondNumber;
        default:
            return secondNumber;
    }
}

function inputDecimal(){
    // eksi bir olması için de yok demek yoksa onu denemek istiyorus
  if(displayValue.indexOf(".")==-1) displayValue+=".";
};
function clearDisplay(){
    displayValue= "0";
    waitingForSecondValue=false;
    previousValue=null;
    operator=null;
};

// kontrol fonsiyonun olduğu nokta bu kısım
function inputNumber(num){
    if(!waitingForSecondValue){ 
        displayValue =displayValue=="0"? num: displayValue + num;
    }else{
        // sayı girdiğimiz kısım ya ilk ya operetore sayı girdiğimiz zaman burası çalışacak
        displayValue=num;
        waitingForSecondValue=false;
    }
}
updateDisplay();