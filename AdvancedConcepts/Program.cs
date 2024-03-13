using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yield
            List<int> numbers = new List<int>() { 1, 5, 6, 3, 5, 7, 4, 3 };
            var yieldConcept = new YieldConcept();
            var list1 = YieldConcept.SimpleConcept(3,numbers);
            var list2 = YieldConcept.YieldFunction(5,numbers);

            //Delegate
            var actionDelegate = new ActionDelegate();
            //actionDelegate.LongFunction(actionDelegate.CallBack);


            //Lambda Expression
            LambdaPred.GenerateExpressionTree();
        }
    }

    
}
