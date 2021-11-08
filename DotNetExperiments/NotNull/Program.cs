using System;

namespace NotNull
{
    class Program
    {
        static void Main(string[] args)
        {
            double? foo = 42;
            double? bar = null;

            Console.WriteLine(foo != null); // True
            Console.WriteLine(foo is not null); // True

            Console.WriteLine(bar != null); // False
            Console.WriteLine(bar is not null); // False
        }
    }
}
