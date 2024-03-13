using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLEarning
{
    public class MethodOverloading
    {

        // its not method overloading when names are same but return type are different
        // Method Overloading can be achieved by having Same name
        /// <summary>
        /// Changing number of arguments
        /// Changing order of arguments 
        /// </summary>

        void Display()
        {
            Console.WriteLine("Simple Display Function");
            
        }
        void Display(int a)
        {
            Console.WriteLine("Simple Display Function with one Int  "+a);
        }

        void Display(int a, int b)
        {
            Console.WriteLine("Simple Display Function with two Int  " + a +"  "+b);
        }

        //int Display() { return 0; } will throw an error
        //int Display(int a) { return 0; }

    }
}
