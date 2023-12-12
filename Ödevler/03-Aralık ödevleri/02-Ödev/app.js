//2) Ask the useer to enter data with a prompt to enter a number greater than 100 each time. If he enters a different value, request that he enter the value again.

function enterNumber() {
    let number = prompt("Please enter a number greater than 100");

    if (isNaN(number)) {
        alert("You did not enter a valid number.Please tyr again.");
        enterNumber();
    } else {
        if (number <= 100) {
            alert("The number you entered is less than or equel to 100.Please try again.");
            enterNumber();
        } else {
            alert("Entered number: " + number);
        }
    }
}
enterNumber();




