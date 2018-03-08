using System;

namespace PriceSubscriber.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var subscriber = new PriceSubscriber();
            subscriber.Subscribe();
        }
    }
}
