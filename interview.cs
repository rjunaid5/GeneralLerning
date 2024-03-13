
int display(int a);
string display(int a);


int display(int a):// this is overloading
string display(string a); // it will work this can be used

Student s;// it means student s is null


using (Person s = new Person())
{
    // using statement must be implicitly convertible to 'System.IDisposable'.PatternTesting  C:\IDWARE\Interview Preperation\CSharpLEarning\PatternTesting\Program.cs    33  Active

    //Cannot be used. Becuase person is not implementing IDispose
}


Student s1=new Student();

Student.Display();

Student s=null;

var a=_context.Students;
a=a.Where(x=>x.isActive);
a=a.toList();


using(Student s=new Student(){
 
});


/*method Hiding is done by using new keyword*/

public class My_Family
{

    public void member()
    {
        Console.WriteLine("Total number of family members: 3");
    }
}

// Derived Class 
public class My_Member : My_Family
{

    // Reimplement the method of the base class 
    // Using new keyword 
    // It hides the method of the base class 
    public new void member()
    {
        Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, " +
                               "Age: 39 \nName: Rohan, Age: 20 ");
    }
}

// Driver Class 
class GFG
{

    // Main method 
    static public void Main()
    {

        // Creating the object of the derived class 
        My_Member obj = new My_Member();

        // Access the method of derived class 
        obj.member();
    }
}