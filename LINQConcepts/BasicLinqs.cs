using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConcepts
{
    internal class BasicLinqs
    {
        public static void SelectAndSelectMany()
        {
            //Select is applied on basic collection
            var numbers = new List<int>() { 1 ,3 ,5 ,6 ,7 ,8 ,9};
            var multiplied = numbers.Select(x => x * x)?.ToList();

            //Select Many is applied on nested collections

            var nestedLists = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5, 6 },
                new List<int> { 7, 8, 9 }
            };

            var flattenedList = nestedLists.SelectMany(list => list);

            // Result: 1, 2, 3, 4, 5, 6, 7, 8, 9
            var squaredNumbers = nestedLists.SelectMany(list => list, (list, number) => number * number);

            // Result: 1, 4, 9, 16, 25, 36, 49, 64, 81
        }

        
    }
}
