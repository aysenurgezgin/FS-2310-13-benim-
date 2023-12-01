//Convert the code below into an if else structure.
// switch (browser) {
//     case 'Edge':
//     alert( "You are using edge browser" );
//     break;
    
//     case 'Chrome':
//     case 'Firefox':
//     case 'Safari':
//     case 'Opera':
//     alert( 'Okay, we support these.' );
//     break;
    
//     default:
//     alert( 'I hope your page looks nice' );
//     } 
//Conclusion;
let broswer = prompt("Enter broswer information: ");

if (broswer === 'Edge') {
    alert("You are using Edge broswer");
} else if (broswer === 'Chrome' || broswer === 'Firefox' || broswer === 'Safari' || broswer === 'Opera') 
{
    alert('Ok, we support these.');
} else {
    alert('I hope your page looks nice');
}