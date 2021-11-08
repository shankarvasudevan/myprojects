using System;

namespace References
{
    public sealed class Foo
    {
        public Foo()
        {
            Console.WriteLine("Constructing Foo");
        }

        public void Print()
        {
            Console.WriteLine("Foo");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing Foo");
        }
    }

    public sealed class Bar
    {
        public Bar(Foo foo)
        {
            Foo = foo;
            Console.WriteLine("Constructing Bar");
        }

        public void Print()
        {
            Console.WriteLine("Bar");
        }

        public Foo Foo { get; }

        public void Dispose()
        {
            Console.WriteLine("Disposing Bar");
            Foo.Dispose();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();
            foo.Print();

            Bar bar = new Bar(foo);
            bar.Dispose();

            foo.Print();
        }
    }
}
