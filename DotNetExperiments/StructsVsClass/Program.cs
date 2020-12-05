using System;

namespace StructsVsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo f = null;
            Console.WriteLine("Hello World!");
        }
    }

    struct Foo
    {
        int X;
        int Y;
    }
}
