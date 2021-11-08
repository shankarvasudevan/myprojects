using System;
using System.Collections.Generic;

namespace DictionaryReference
{
    public class Foo
    {
        public int Value { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, Foo>();
            
            var foo1 = new Foo { Value = 42 };
            dict.Add(1, foo1);

            var foo2 = dict[1];
            foo2.Value = 43;

            var foo3 = dict[1];

            Console.WriteLine($"Foo1 [Value: {foo1.Value}, HashCode: {foo1.GetHashCode()}]");
            Console.WriteLine($"Foo2 [Value: {foo2.Value}, HashCode: {foo2.GetHashCode()}]");
            Console.WriteLine($"Foo3 [Value: {foo3.Value}, HashCode: {foo3.GetHashCode()}]");

        }
    }
}
