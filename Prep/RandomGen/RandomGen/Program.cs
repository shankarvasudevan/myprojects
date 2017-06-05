using System;

namespace RandomGen
{
	class MainClass
	{
		public static void Main (string [] args)
		{
			Console.WriteLine ("Press ENTER to read next Random number. Press Ctrl+D to end");

			var numbers = new int[] { 1, 2, 3 };
			var probabilities = new float[] { 0.2f, 0.3f, 0.5f };
			var randomGen = new RandomGen(numbers, probabilities);

			while (Console.ReadKey().Key == ConsoleKey.Enter) 
			{
				Console.WriteLine ("NextNum: {0}", randomGen.NextNum ());
			}
		}
	}
}
