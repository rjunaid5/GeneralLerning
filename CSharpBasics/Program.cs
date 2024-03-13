using CSharpLEarning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Program
    {
        public static int statInt;
        static void Main(string[] args)
        {
            var a = "asddas"; // always need to initialized
           // a = 12;// var type cannot be changed
            dynamic d;
            d = 12;
            d = "assaddsaasd"; // dynamic type can be changed

            object obj;

            obj = 12;//object not need to initialized, it is also specified at run time
            obj = "ASsdaasd";



            CheckOutVariables(34, out int outInt);


            int x1 = 12;
            CheckRefVariables(34, ref x1);// x1 must be initialized before calling


            Console.WriteLine("Out Variable" + outInt);
            var temp = new AccessModifiers();
            temp.Print();
            //temp.parentInt2 = 7; it will throw an error becuase it is another assembly
            

        }

        static void CheckOutVariables(int a, out int outInt)
        {
            // it needs to initialized in the function otherwise will throw an error
            outInt = 12;
            outInt = a + outInt;
        }


        static void CheckRefVariables(int a, ref int refInt)
        {
            
            refInt = a + refInt;
        }

    }


    public class Test: AccessModifiers
    {
        
        Test()
        {
            // parentInt3 is only accessible because it is from parentClass AccessModifier and from another assembly
            Console.WriteLine(this.parentInt3); 
            Console.WriteLine(Program.statInt);
        }
    }
}
