using System;
namespace DotNetConcepts
{
    public class OrChecker
    {
        static void Main() 
        {
            Console.WriteLine(Foo() || Bar());
        }

        private static bool Foo()
        {
            Console.WriteLine("Foo");
            return false;
        }

        private static bool Bar()
        {
            Console.WriteLine("Bar");
            return false;
        }
    }
}
