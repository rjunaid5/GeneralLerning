//Hoisting
// JS moves all the variable declaration at the top and will assume that later it has value
//e,g

console.log(test);//here JS will not say that test is not defined yet rather its defined but value is undefined
var test = "asdasd"

/*
Execution will be like this

var test;
console.log(test);
test = "asdasd"

*/


//Let variables are also hoisted but they are in dead zone

console.log(test1);//it will throw an error
let test1 = "asdds"