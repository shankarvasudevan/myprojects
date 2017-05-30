using System;

namespace RandomGen
{
	class MainClass
	{
		public static void Main (string [] args)
		{
			var numbers = new int[] { 1, 2, 3 };
			var probabilities = new float[] { 0.04f, 0.9f, 0.06f };
			var randomGen = new RandomGen(numbers, probabilities);

			Console.WriteLine("NextNum: {0}", randomGen.NextNum());
		}
	}
}
