using System;
using System.Collections.Generic;

namespace DictionaryRemove
{
    public sealed class Foo
    {
        public Foo(int value)
        {
            Console.WriteLine($"Constructing foo {value}"); 
            Value = value; 
        }

        public int Value { get; set; }

        public void Dispose() { Console.WriteLine($"Disposing foo {Value}"); }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var set = new HashSet<Foo>();

            var f1 = new Foo(1);
            var f2 = new Foo(2);
            var f3 = new Foo(3);

            set.Add(f1);
            set.Add(f2);
            set.Add(f3);

            Console.WriteLine("Removing f2 from the set");
            set.Remove(f2);

            Console.WriteLine("Changing value of f2");
            f2.Value = 666;

            Console.WriteLine($"f2 = {f2.Value}");
        }
    }
}
