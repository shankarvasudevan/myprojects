using System;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            bool result1 = x > 0;

            Console.WriteLine(result1);

            double? y = null;
            double? z = 42.0;

            bool result2 = y > x;
            bool result3 = x > y;

            Console.WriteLine(result2);
            Console.WriteLine(result3);          
        }
    }
}
