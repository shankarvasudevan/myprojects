using System;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Hello World!");

            var t1 = Task.Run(() => 
            {
                var s1 = Singleton.GetInstance();
                Console.WriteLine($"s1 = {s1.GetHashCode()}");
            });

            var t2 = Task.Run(() => 
            {
                var s2 = Singleton.GetInstance();
                Console.WriteLine($"s2 = {s2.GetHashCode()}");
            });

            Task.WaitAll(new[] { t1, t2 });

            Console.WriteLine("Finished");
        }
    }

    public static class Singleton
    {
        private static int randomInt = new Random().Next();
        private static Random rand = new Random();

        public static int GetInstance() 
        {
            return randomInt;
        }
    }
}
