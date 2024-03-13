
//using System;
///// <summary>
///// From version 7.0, C# introduced a new feature called discards to create dummy variables, defined by the underscore character _. Discards are equal to unassigned variables. 
///// The purpose of this feature is to use this variable when you want to intentionally skip the value by not creating a variable explicitly.
///// </summary>
/////Without Discards Variable
//DateTime result;
//if (DateTime.TryParse("02/29/2019", out result))
//{
//    Console.WriteLine("Date is valid");
//}
//else
//{
//    Console.WriteLine("Date is not valid");
//}
/////With discards
/////
//if (DateTime.TryParse("02/29/2019", out _))
//{
//    Console.WriteLine("Date is valid");
//}
//else
//{
//    Console.WriteLine("Date is not valid");
//}

//namespace Testing
//{

//    public class Program
//    {
//        public static void Main()
//        {
//            DateTime result;
//            if (DateTime.TryParse("02/29/2019", out result))
//            {
//                Console.WriteLine("Date is valid");
//            }
//            else
//            {
//                Console.WriteLine(result);
//            }
//        }
//    }
//}