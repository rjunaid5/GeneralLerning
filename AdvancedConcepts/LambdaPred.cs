using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts
{
    public static class LambdaPred
    {
        private static List<string> listTest = new List<string>() {"Test1", "test12", "TEST235","Test34" };
        private delegate double CalArea(int a);
        private delegate double CalAreaLamda(int a);
        public static void SimpleDelegate()
        {
            var delpointer = new CalArea(delegate (int r) { return 3.15 * r * r; });
            var area = delpointer(6);
            // Instead of writing long functions we wrote Delegate
        }

        public static void LambdaTest()
        {
            CalAreaLamda areaLamda = r => 3.4 * r * r;
        }

        public static void FuncTest()
        {
            //Takes an int and provides output as double
            Func<int, double> func = r => 3.4 * r * r;
            var value = func(4);
        }

        public static List<string> GeneratePredicate()
        {
            Predicate<string> predicate = x => x.Contains("st1");
            var newList =  listTest.FindAll(predicate);
            return newList;
        }

        public static void GenerateExpressionTree()
        {
            ParameterExpression parameter = Expression.Parameter(typeof(string), "s");

            // Build the first condition: string length > 5
            Expression lengthCondition = Expression.GreaterThan(
                Expression.PropertyOrField(parameter, "Length"),
                Expression.Constant(5)
            );

            // Build the second condition: string contains the letter 'a'
            MethodInfo containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            Expression containsCondition = Expression.Call(
                parameter,
                containsMethod,
                Expression.Constant("est1")
            );
            Expression combinedCondition = Expression.AndAlso(lengthCondition, containsCondition);

            // Create a lambda expression
            var lambda = Expression.Lambda<Func<string, bool>>(combinedCondition, parameter);

            var filteredStrings = listTest.Where(lambda.Compile());

            // Display the result
            foreach (var str in filteredStrings)
            {
                Console.WriteLine(str);
            }
        }
    }
}