using SOLIDPrinciples;
using SolutionOCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{

    public sealed class SingletonClassLock
    {
        //this will have only problem with multithreading
        //because when using multithreading there is a chance that multi threads will create more than
        // one instance of class
        private static SingletonClassLock Instance = null;
        private static int counter = 0;

        private static object lockObj = new object();
        public static SingletonClassLock GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    lock (lockObj)
                    {
                        if (Instance == null)
                        {
                            Instance = new SingletonClassLock();
                        }

                    }
                }
                
                // in this way Singleton will be instantiated one time only
                return Instance;
            }
            
        }

        //Constructor is private so that class is instantiated within itself
        private SingletonClassLock()
        {
            counter++;
            Console.WriteLine("Counter is " + counter);
             
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message + Environment.NewLine);
        }
    } 
}
