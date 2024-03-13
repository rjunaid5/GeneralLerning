using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    /// <summary>
    /// This Pattern is used when we just want to create a single instance of class
    /// and all other objects want to use this class
    /// For example there is one simple functionality which will be same everywhere
    /// so we dont need to create new instances everywhere
    /// </summary>
    /// For singleton class we need to make it sealed and make its Members private
    /// 

    public class SingletonPatternProblem
    {
        public SingletonPatternProblem()
        {

        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }


    //why we need sealed class if we are using just private Constructor
    /// <summary>
    /// Because when we inherit this class it will throw an error because
    /// child class cannot intansiate parent constructor because it is private
    /// </summary>
    public sealed class SingletonClass
    {
        //this will have only problem with multithreading
        //because when using multithreading there is a chance that multi threads will create more than
        // one instance of class
        private static SingletonClass Instance = null;
        private static int counter = 0;
        public static SingletonClass GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new SingletonClass();
                }
                // in this way Singleton will be instantiated one time only
                return Instance;
            }
            
        }

        //Constructor is private so that class is instantiated within itself
        private SingletonClass()
        {
            counter++;
            Console.WriteLine("Counter is " + counter);
             
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message + Environment.NewLine);
        }
    } 

    public class ClassesImplementation
    {
        public  ClassesImplementation()
        {
            var problemClass = new SingletonPatternProblem();
            problemClass.PrintDetails("One Instance");

            var problemClass1 = new SingletonPatternProblem();
            problemClass1.PrintDetails("Second Instance");

            var solutionInstance1 = SingletonClass.GetInstance;
            solutionInstance1.PrintDetails("From Studen instance");

            var solutionInstance2 = SingletonClass.GetInstance;
            solutionInstance1.PrintDetails("From Employee instance");


        }
    }
}
