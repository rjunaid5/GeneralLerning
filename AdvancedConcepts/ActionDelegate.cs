using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts
{
    internal class ActionDelegate
    {
        // Delegate is pointer to function  or to anything
        public delegate void PtrToFunction();
        public delegate void PtrToLongFunction(int i);

        public ActionDelegate()
        {
            PtrToFunction ptrToFunction = new PtrToFunction(TestFunction);
            ptrToFunction.Invoke();
            // why we need this instead of calling directly TestFunction()
            // Delegate is always a callback it can tell what is happenning inside some long function
        }

        public void LongFunction(PtrToLongFunction ptr)
        {
            for(int i = 0; i < 10000; i++)
            {
                if (i > 102)
                {
                    ptr(i);
                }                
            }
        }
        public void CallBack(int i)
        {
            //Log.Info(Log when value is greater than 120)
            Console.WriteLine(i);
        }
        public void TestFunction()
        {
            Console.WriteLine(nameof(PtrToFunction));
        }

        
    }
}
