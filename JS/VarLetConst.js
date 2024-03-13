//var vs let vs const


var a = 6; // var is function/global scope
function name() {
    console.log(a)
}

array.forEach(element => {
    // this is a block
    let b = 7;
});

console.log(b);//cannt access
{
    //this is a block
console.log(b);//cannt access
}

// Shadowing Let variable
function Shadow() {
    let a = "Hello"
    let b = "Test"
    if (true) {
        let a = "Hi";
        var b = "asd"//Error it cannot be shadowed
        console.log(a) // Hi
    }
    console.log(a) // Hello

}