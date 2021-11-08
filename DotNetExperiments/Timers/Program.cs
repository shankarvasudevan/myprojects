using System;
using System.Timers;

namespace Timers
{
    class Program
    {
        static void SayHello(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Hello");
        }

        static void Main(string[] args)
        {
            var timer = new Timer(2000);
            timer.Elapsed += SayHello;
            timer.Start();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
