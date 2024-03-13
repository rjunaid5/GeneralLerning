using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    /*
     - Program vs Process vs Thread
     - Program is present on hard drive and process is execution of pogram in RAM
     - Like Word is a program and when it is executed it becomes a process
     - We can see Processes in TaskManager
     - Each Process has multiple threads
     */
    internal class ThreadAndTasks
    {
        /*
         - Aysnc doesnot create threads or omprove performance, it ensures that 
         the main thread which is doing the process is non-blocking
         - when you start a process than if that process is executed than next process will start
         but running async
         */
        public async void CheckThread()
        {
            await Task.Delay(10000);// this will create a new thread(worker) only to show that
                                    // delay is finished and main thread can continue
            Console.WriteLine("ASASDDASSDA");
        }

        /*
         - Concurency means there are two tasks but they run on same core
           and there is some switching of tasks
         - Concurent application has an undetermisitic output. some tasks finish fast than other
         - Parallelism runs tasks on different cores which is achieved Task.Factory.startNew
         */

        //Concurency

        public static void MainCalling()
        {
            Task.Factory.StartNew(Method3);//this will create a new thread

            //Task.Start() also starts new thread
            Method1();
            Method2();
            

            Console.WriteLine("MAinCalling");
            Console.WriteLine("MAinCalling1");
            Console.WriteLine("MAinCalling2");
            string str = Console.ReadLine();
        }


        //Parallelism
        /*
         Task.whenAll() is used when you want to do some operation with multiple task in parallel
        and wait until all of them are completed
         */
        public static async void ThreadAndTaskCalling()
        {
            List<Task> tasks = new List<Task>();
            tasks.Add(new Task(() =>
            {
                Console.WriteLine("Running Task on seperate Thread");
                int numbers = AddNumbers(12, 45);
                Console.WriteLine($"Result of Addition is:{numbers}");
            }));
            tasks[0].Start();
            var task1 = Task.Run(() =>
            {
                Console.WriteLine("Running Task on seperate Thread1");
                int numbers = AddNumbers(121, 453);
                Console.WriteLine($"Result of Addition is:{numbers}");
            });
            tasks.Add(task1);
            var task2 = Task.Run(() =>
            {
                Console.WriteLine("Running Task on seperate Thread2");
                int numbers = AddNumbers(122, 145);
                Console.WriteLine($"Result of Addition is:{numbers}");
            });
            tasks.Add(task2);
            await Task.WhenAll(tasks).ConfigureAwait(false);


            Console.WriteLine("MAinCalling");
            Console.WriteLine("MAinCalling1");
            Console.WriteLine("MAinCalling2");
            string str = Console.ReadLine();
        }

        private static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        private static async void Method1() // Concurent
        {
            await Task.Delay(100);// this will create a new thread(worker) only to show that
                                    // delay is finished and main thread can continue
            Console.WriteLine("Method1");
        }
        private static async void Method2()
        {
            await Task.Delay(1000);// this will create a new thread(worker) only to show that
                                    // delay is finished and main thread can continue
            Console.WriteLine("Method2");
        }
        private static async void Method3()
        {
            await Task.Delay(1000);// this will create a new thread(worker) only to show that
                                    // delay is finished and main thread can continue
            Console.WriteLine("Method3");
        }


    }
}
