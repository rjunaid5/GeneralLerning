/*
js is dynamic languange meaning data types can change during run time
it determines data types by looking at them at run time
typeof() will determines type
*/

var x = 12;
x = "asd";

//Types in JS: 8 data types
var nu = null // null means variable has value but it is null.
var und = undefined // meaning variable is declared but doesnot have any value

/*
JS Hoisting
it means all the variables are declared on the top, during the execution it will move variable declaration
value to top

*/
console.log(v)
var v = 10;//this will be moved to the top

"use Strict"; // it will strictly check if variable is defined using var keyword if not it will throw an error
var x = 10;
y = 12; // it will throw an error


/* Closures---
Closure are function within a function
Clousre function will hold values in a memory and they will be passed by reference

* */

function ClosureFunc() {
    var x = 10;
    function Increment() {
        x++;
    }
    return Increment;
}
var ref = ClosureFunc(); // this is to avoid global variables
ref.Increment(); // x = 10
ref.Increment(); // x= 12

//IIFE is the immediate invoked function
// In Js IIFE is self invoking and it will be without name
// variable inside IIFE is local to scope
var x = 0;
(function(){ alert("ASsdaasd")})();
