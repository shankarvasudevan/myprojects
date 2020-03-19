using System;
using System.Threading;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromMilliseconds(50));

            using (observable.Subscribe(_ =>
            {
                Task.Run(() => DoSomething(DateTime.Now));
            })
            {
                Console.WriteLine("Press any key to unsubscribe");
                Console.ReadKey();
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static void DoSomething(DateTime curr)
        {
            Console.WriteLine(curr);
            Thread.Sleep(2000);
        }

    }
}
