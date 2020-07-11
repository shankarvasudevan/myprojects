using System;

namespace InheritanceWithStatics
{
    class Foo
    {
        public static readonly string Name = "Foo";

        public Foo(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }
    }

    class Bar : Foo
    {
        public static readonly string Name = "Bar";

        public Bar(int value) : base(value)
        {
            Value = value;
        }

        public new int Value { get; private set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Foo f = new Bar();

            Console.WriteLine(f.Name);
            Console.WriteLine(f.Value);

        }
    }
}
