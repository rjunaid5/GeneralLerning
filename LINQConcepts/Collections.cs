using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConcepts
{
    internal class Collections
    {
        //List:IList -> IList : ICollection -> ICollection : IEnumerable
        public static void CheckEnumerable()
        {
            /*
             * IEnumerable is the most basic interface that represents a forward-only cursor of a collection.
                It allows you to iterate over a collection using a foreach loop.
                It provides a generic method GetEnumerator that returns an IEnumerator
             */
            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public static void CheckICollection()
        {
            /*
             * ICollection extends IEnumerable and adds methods for adding, removing, and checking the existence of elements in a collection.
                It includes properties like Count to get the number of elements in the collection.
             */
            ICollection<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            numbers.Add(6);
            numbers.Remove(3);

            Console.WriteLine("Count: " + numbers.Count);
        }

        public static void CheckIList()
        {
            /*
             * IList extends ICollection and adds methods to manipulate elements at specific indices,
             * like Insert, RemoveAt, and indexing.
                It allows for random access to elements.
             */
            IList<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            numbers.Insert(2, 10);
            numbers[0] = 100;

            Console.WriteLine("Element at index 2: " + numbers[2]);
        }

        public static void CheckIQueryable()
        {
            // IQueryable is basically database query
            IQueryable<int> list = new List<int> { 2, 4, 56, 4, 67, 4, 6, 61, 63, 4, 2 }.AsQueryable();
            var query = list.Where(x => x > 50).Select(x => x.ToString());
        }

    }

}
