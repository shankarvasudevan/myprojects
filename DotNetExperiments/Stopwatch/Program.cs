using System;
using System.Diagnostics;

namespace StopwatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            while (sw.ElapsedMilliseconds < 30000)
            {
                if (sw.ElapsedMilliseconds % 10 == 0)
                {
                    Console.WriteLine($"{sw.ElapsedMilliseconds}");
                }                
            }
        }        
    }
}
