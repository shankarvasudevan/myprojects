using System;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
		int? x = null;
		bool result = x > 0;

		Console.WriteLine(result);
        }
    }
}
