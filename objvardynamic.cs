Difference between Var and Dynamic


// var is implicit variable whose type is specified at compile time. so you have to specify type and value must be assigned
// dynamic variables type are assigned or got at runtime. no need to assign value to it value will be decided at run-time
// object type is also specified at compile time same like var but for usage it is needed to be casted into respectibe type. Objects type can be changed 

var a = "ASDasd";
dynamic b;
var c;  // There will be Error
object z1= 6;
object x2;

dynamic d = 64;
d ="asdasdasd";
Console.WriteLine ("Hello Mono World"+d); output will be Hello Mono Worldasdasdasd



//- VAR
private static void temp(var test)// it will throw an error because for functions type is necessary
{
    Console.WriteLine ("dfsdfds");
} 

//- Dynamic
private static void temp1(dynamic test)// it is ok
{
    Console.WriteLine (test);
}

//- Object
object x2 = 12;
x2 = "ASSDAASDASD";
object x1;
x1 = 56;
int x2 = x1 + 34; // it will throw an error. x1 needs to type casting

// ---- BOXING casting any variable into object

var a = "ASASDasdasd";
object x1 = a;



// Static function must call static functions only otherwise object reference will be required.
// in a static class all members must be static