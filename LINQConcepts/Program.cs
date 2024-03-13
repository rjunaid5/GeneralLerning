using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqAdvConcepts linqAdvConcepts = new LinqAdvConcepts();
            //linqAdvConcepts.CheckLinqConcepts();
           // linqAdvConcepts.CheckLinqAdvConcepts();
            linqAdvConcepts.CheckPersonJoins();
        }
    }
}
