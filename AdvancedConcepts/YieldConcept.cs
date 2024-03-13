using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts
{
    public class YieldConcept
    {
        public static IEnumerable<int> SimpleConcept(int upto, List<int> nums)
        {
            // For mostly collections like IEnumerable when doing any operation on
            // them instead of creating new list yeild key can be used to return list

            List<int> newNums = new List<int>();
            foreach (var item in nums)
            {
                if (item > upto)
                {
                    newNums.Add(item);
                }
            }
            return newNums;
        }
        public static IEnumerable<int> YieldFunction(int upto, List<int> nums)
        {
            // For mostly collections like IEnumerable when doing any operation on
            // them instead of creating new list yeild key can be used to return list

            
            foreach (var item in nums)
            {
                if (item > upto)
                {
                    yield return item;
                }
            }
            
        }
    }
}
