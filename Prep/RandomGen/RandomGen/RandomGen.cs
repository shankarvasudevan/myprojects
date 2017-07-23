using System;
using System.Linq;

namespace RandomGen
{
	public class RandomGen
	{
		// 4 bytes
		private const int ExtrapolationAmount = 100;

		// 4 * 100 + 8 for object reference (assuming 64-bit) = 408
		private readonly int[] numsExtrapolatedByProbability = new int[ExtrapolationAmount];

		// Random class: 
		private readonly Random random;

		public RandomGen(int[] randomNums, float[] probabilities)
		{
			this.ValidateInput(randomNums, probabilities);
			int[] extrapolatedProbabilities = ExtrapolateProbabilities (probabilities, ExtrapolationAmount);
			this.numsExtrapolatedByProbability = FillByProbabilities(randomNums, extrapolatedProbabilities, ExtrapolationAmount);
			this.random = new Random();
		}

		public int NextNum()
		{
			int nextNumIndex = this.random.Next() % ExtrapolationAmount;
			return numsExtrapolatedByProbability[nextNumIndex];
		}

		public static int[] ExtrapolateProbabilities(float[] probabilities, int extrapolationAmount)
		{
			int[] extrapolatedProbabilities = new int[probabilities.Length];
			bool shouldRoundUp = true;

			int extrapolationCount = 0;
			for (int i = 0; i < probabilities.Length && extrapolationCount < extrapolationAmount; i++) 
			{
				float extrapolatedProb = probabilities[i] * extrapolationAmount;
				int truncatedProb = (int)extrapolatedProb;

				if ((extrapolatedProb - (float)truncatedProb) > float.Epsilon) 
				{
					if (shouldRoundUp) 
					{
						truncatedProb += 1;
					}

					shouldRoundUp = !shouldRoundUp;
				}

				while (extrapolationCount + truncatedProb > extrapolationAmount) 
				{
					truncatedProb--;
				}

				extrapolatedProbabilities[i] = truncatedProb;
				extrapolationCount += truncatedProb;
			}

			return extrapolatedProbabilities;
		}

		public static int[] FillByProbabilities(int[] numbers, int[] extrapolatedProbs, int extrapolationAmount)
		{
			int[] numbersByProbability = new int[extrapolationAmount];

			/*
			 * 10,11,12,13
			 * 1,2,3,4
			 * -----------
			 * 10,11,11,12,12,12,13,13,13,13
			 */

			int count = 0;
			for (int i = 0; i < numbers.Length; i++) 
			{
				for (int j = 0; j < extrapolatedProbs[i]; j++) 
				{
					numbersByProbability[count++] = numbers[i];
				}
			}

			return numbersByProbability;
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
