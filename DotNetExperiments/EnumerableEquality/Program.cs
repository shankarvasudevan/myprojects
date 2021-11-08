using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumerableEquality
{
    class Program
    {
        
        class Foo { }

        static void Main(string[] args)
        {
            var a = new Foo();
            var b = new Foo();
            var c = new Foo();

            var first = new[] { a, b, c};
            var second = new[] { c, b, a };

            var result = Enumerable.SequenceEqual(first.OrderBy(f => f), second.OrderBy(s => s));

            Console.WriteLine(result);
        }
    }
}
