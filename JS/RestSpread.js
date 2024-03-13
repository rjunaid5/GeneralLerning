/*
Rest or spread parameter must be last one
*/

const printmethod = function(num, num1, ...numbers){
    console.log(num,num1, numbers)
}

printmethod(1,5 , 3 , 7, 8);// 1,5,[3,7,8]

/*
What is IIFE
when we need to call function rightaway using ()
* */

(function squareF() {
    return 5 * 5;
})();//this is IIFE

