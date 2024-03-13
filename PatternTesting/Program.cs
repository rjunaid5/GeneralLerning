using DesignPatterns.SingletonPattern;
using SOLIDPrinciples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var signleton1 = SingletonClass.GetInstance;
            //signleton1.PrintDetails("From Testing");

            //var signleton2 = SingletonClass.GetInstance;
            //signleton2.PrintDetails("From Testing");

            //counter for instantiation will be 0 because only one instance

            //this is good example of action why we use
            //Invoke would need an action
            Parallel.Invoke(
                () => FromStudenMethod(),
                () => FromTeacherMethod()
                );
            // when these two are executed there will be two instantiation
            // in order to avoid that we need to add Thread Lock to avoid Thread race
            // by using lock only one thread instance can enter a particular code at a time

            //using (Person s = new Person())
            //{
            //    // using statement must be implicitly convertible to 'System.IDisposable'.PatternTesting  C:\IDWARE\Interview Preperation\CSharpLEarning\PatternTesting\Program.cs    33  Active

            //    //Cannot be used. Becuase person is not implementing IDispose
            //}

            Console.ReadKey();

        }

        private static void FromTeacherMethod()
        {
            var fromTeacher = SingletonClass.GetInstance;
            fromTeacher.PrintDetails("fromTeacher Testing");
        }

        private static void FromStudenMethod()
        {
            var fromStrudent = SingletonClass.GetInstance;
            fromStrudent.PrintDetails("From Student Testing");
        }
    }
}
