// Need OF OOP
/*
OOP helps us to think in terms of real world objects

*/
// Partial class means implement class with same name in different files
/*
Access Modifier
protected - can be used within same class or derived classes or derived classes within same project not outside
internal - can be used within same assembly/ name space
privateprotected - 
*/

    public class AccessModifiers
    {
        protected void protectedFunction()
        {

        }
        private void privateFunction()
        {

        }
        internal void testClassesMethods()
        {
            protectedFunction();
            privateFunction();
        }
        private protected void PrivateProtectedMethod()
        {

        }
    }
    
    public class AccessChild: AccessModifiers
    {
        public void TestParentFunction()
        {
            this.protectedFunction();
            //this.privateFunction() not possible
            this.PrivateProtectedMethod();
        }
    }


namespace Test
{
    public class Test
    {
        public void Temp()
        {
            var am = new AccessModifiers();
            am.testClassesMethods();
            
        }
    }

    public class TestProtected: AccessModifiers
    {
        public void Temp()
        {
            var am = new AccessModifiers();
            am.testClassesMethods();
            am.PrivateProtectedMethod(); // cannot access parent because from different namespace/Assembly
        }
    }

}


// Pillars of OOP 
/*
APIE
A- Abstraction - showing only what is necessary
B- Polymorphism - Object acting differently under different conditions
C- Inheritance - Parent Child
E- Encapsulation - Hide complexity  

*/


public Main(){
    var user = new User();
    user.Validate();
}
//Abstraction vs Encapsulation
public class User{

    public string Name { get; set; }
    public string Password { get; set; }
    public void Validate(){
        ValidateUserName();
        ValidatePassword();
    }
    public virtual void Credentials()
    {
        EnterUsername();
    }
    private void EnterUsername(){

    }
    private void EnterPassword(){

    }
    private ValidateUserName(){

    }
    private ValidatePassword(){

    }
}

public class TempUser : User
{
    public override void Credentials()
    {
        EnterUsername();
        EnterPassword();
    } 
}

// Abstraction happens during design phase. what has to be shown public like Name, Password and validate
// During executing phase developer uses Encapsulation(using Access Modifiers Public private protected) to implement his thought process or implement abstraction

// Method overloading is static polymorphism
// Method overriding is dynamic polymorphism

// Inheritance - Virtual - override
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        double i = 7.8;
        int y = (int)i;
        int x =233;
        double z = x;
        Console.WriteLine (z);
        
        User user = new User();
        var tempuser = new TempUser();
        user.Credentials();// 
        tempuser.Credentials(); // Overriding
        tempuser.Credentials(1); // Overloading
        tempuser.Credentials(1,5);
        tempuser.Credentials("344566", 457);
    }
    
}
public class User{

    public string Name { get; set; }
    public string Password { get; set; }
    public void Validate(){
        ValidateUserName();
        ValidatePassword();
    }
    public virtual void Credentials()
    {
        EnterUsername();
    }
    public void EnterUsername(){
        Console.WriteLine ("EnterUsername");
    }
    public void EnterPassword(){
        Console.WriteLine ("EnterPassword");
    }
    public void ValidateUserName(){
        Console.WriteLine ("ValidateUsername");
    }
    public void ValidatePassword(){
        Console.WriteLine ("ValidatePAssword");
    }
}

public class TempUser : User
{
    public override void Credentials()
    {
        Console.WriteLine ("ChildClass");
        EnterUsername();
        EnterPassword();
    }
    
    public void Credentials(int a)
    {
        Console.WriteLine (a+"Overriding");
    }
    
    public void Credentials(int a, int b)
    {
        Console.WriteLine (a+b+"Overriding");
    }
    
    public int Credentials(string a, int b)
    {
        Console.WriteLine (a+b+"Overriding");
        return 2;
    }
    
}
// Non Abstract classes cannot have abstract method
// When base class has a method that is over written in the child classes and not implemented in parent class than in order to prevent 
// User from calling parent class function that method is made abstract
// abstract method in abstract class are by default virtual, any method that needs to be overridden must be virtual
// abstract class cant be initiated



// Interface is a contract , interface cant have logic and cant have private, public , interface properties are all public
// Class inherited from Interface follow interface, meaning all members must implemented
// interface is based on system and client requirement, contract is necessary because if developer changes something he doesnot know where this c
// chnage will cause problem
