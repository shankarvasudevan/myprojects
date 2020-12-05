using System;

namespace ReadOnlyVsProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo f = new Foo();
            Bar b = new Bar();

            int x = f.Value;
            x = 45;

            Console.WriteLine(x);
            Console.WriteLine(f.Value);

            Console.WriteLine(sizeof(Foo));
            Console.WriteLine(sizeof(Bar));
        }
    }

    public class Foo
    {
        public readonly int Value;

        public Foo()
        {
            Value = 42;
        }
    }

    public class Bar
    {
        public Bar()
        {
            Value = 42;
        }

        public int Value { get; }
    }
}
