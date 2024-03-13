/*
Anonymouse function: it has no name it can be assigned to variable or use call back
Functions are assigned to variable called Function Expression 
*/

const square = function(num){
    return num * num;
}

square();

/*
What is IIFE
when we need to call function rightaway using ()
* */

(function squareF() {
    return 5 * 5;
})();//this is IIFE

