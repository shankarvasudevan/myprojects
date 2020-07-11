using System;

namespace PassByValueRef
{
    class Program
    {
        static void Increment(double? x)
        {
            x += 1.0;
        }

        static void Main(string[] args)
        {
            double? x = 2.0;
            Console.WriteLine(x);
            Increment(x);
            Console.WriteLine(x);
        }
    }
}
