// Static variables have their types known at compile-time
// Static function must call static functions only otherwise object reference will be required.
// in a static class all members must be static

// -CONST
// this requires a value to be initialized with once intialized it cannot be changed throughtout the program. it is compile time
 const int a; // iit will throw an error
 const int b = 52;

 // Readonly
 // it is run time its value not need to be assigned and its value can be chnaged by constructor 
 //A static readonly field cannot be assigned to (except in a static constructor or a variable initializer

 using System;
 
class GFG {
 
    // readonly variables
    public readonly int myvar1;
    public readonly int myvar2;
 
    // Values of the readonly 
    // variables are assigned
    // Using constructor
    public GFG(int b, int c)
    {
 
        myvar1 = b;
        myvar2 = c;
        Console.WriteLine("Display value of myvar1 {0}, "+
                        "and myvar2 {1}", myvar1, myvar2);
    }
 
    // Main method
    static public void Main()
    {
        GFG obj1 = new GFG(100, 200);
    }
}