using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 42.0;

            Console.WriteLine(x > y);
            Console.WriteLine(y > x);
        }
    }
}
