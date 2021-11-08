using System;
using System.Collections.Generic;

namespace Casting
{
    // public static class EqualityChecker<T>
    // {
    //     public static bool IsMatch(T expected, object actual)
    //     {
    //         return actual is T && EqualityComparer<T>.Default.Equals(actual, (T)expected);
    //     }
    // }

    class Program
    {
        static void Main(string[] args)
        {
            // object x = 10;
            // int y = 10;

            // var result = EqualityChecker<int>.IsMatch(y, x);

            // Console.WriteLine(result);

            var result = ((int)10.5).Equals(10);

            Console.WriteLine(result);
        }
    }
}
