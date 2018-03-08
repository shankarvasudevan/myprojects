using System;

namespace PricePublisher.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var publisher = new PricePublisher();
            publisher.Publish();
        }
    }
}
