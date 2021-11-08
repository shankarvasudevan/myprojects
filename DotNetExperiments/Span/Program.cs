using System;

namespace Span
{
    readonly ref struct Bar
    {
    }

    class Foo
    {
        public event Action<Bar> SendBarHandler; 
        public void CreateAndSendBar()
        {
            Bar bar;
            Console.WriteLine($"Created bar: [Hashcode: {bar.GetHashCode()}]");
            SendBar(bar);
        }

        private void SendBar(Bar bar)
        {
            Console.WriteLine($"Sending bar: [Hashcode: {bar.GetHashCode()}]");
            SendBarHandler?.Invoke(bar);
        }
    }

    class BarSender
    {
        BarSender(Foo foo)
        {
            foo.SendBarHandler += DoSendBar;
        }

        void DoSendBar(Bar bar)
        {
            Console.WriteLine($"Inside DoSendBar: [Hashcode: {bar.GetHashCode()}]");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Foo foo;
            BarSender sender = new BarSender(foo);

            foo.CreateAndSendBar();
        }
    }
}
