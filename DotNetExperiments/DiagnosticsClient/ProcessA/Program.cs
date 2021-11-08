using System;
using System.Threading;

namespace ProcessA
{
    class Program
    {
	static void Main(string[] args)
	{
		while (true)
		{
			Thread.Sleep(1000);
			Console.WriteLine("Hello");
		}
	}
    }
}
