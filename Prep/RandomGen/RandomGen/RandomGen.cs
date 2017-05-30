using System;
using System.Linq;

namespace RandomGen
{
	public class RandomGen
	{
		public static readonly int ExtrapolationAmount = 100;

		private readonly int [] numbersByProbability = new int[ExtrapolationAmount];
		private readonly Random random;

		public RandomGen(int[] randomNums, float[] probabilities)
		{
			this.ValidateInput(randomNums, probabilities);
			this.FillNumbersByProbability(randomNums, probabilities);
			this.random = new Random(DateTime.Now.Millisecond);
		}

		public int NextNum()
		{
			int nextNumIndex = this.random.Next() % ExtrapolationAmount;
			return numbersByProbability[nextNumIndex];
		}

		private void FillNumbersByProbability(int[] numbers, float[] probs)
		{
			int[] extrapolatedProbs = new int[probs.Length];
			for (int i = 0; i < probs.Length; i++) 
			{
				extrapolatedProbs[i] = (int) (probs[i] * ExtrapolationAmount);
			}

			int count = 0;
			for (int i = 0; i < numbers.Length; i++) 
			{
				for (int j = 0; j < extrapolatedProbs[i]; j++) 
				{
					this.numbersByProbability[count++] = numbers[i];
				}
			}
		}

		private void ValidateInput(int[] numbers, float[] probs)
		{
			if (numbers == null || numbers.Length == 0) 
			{
				throw new InvalidInputException ("No random numbers specified");
			}

			if (probs == null || probs.Length == 0) 
			{
				throw new InvalidInputException ("No probabilities specified");
			}

			if (probs.Length != numbers.Length) 
			{
				throw new InvalidInputException ("Number of probabilities not equal to number of random numbers");
			}

			if (Math.Abs (probs.Sum () - 1) > float.Epsilon) 
			{
				throw new InvalidInputException ("Probabilities do not sum to 1");
			}

			foreach (float prob in probs) 
			{
				if (prob < 0 || prob > 1) 
				{
					throw new InvalidInputException ("Probabilities should be between 0 and 1");
				}
			}
		}
	}
}
