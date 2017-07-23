using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace RandomGen.Tests
{
	[TestFixture]
	public class RandomGenTests
	{
		public static IEnumerable<TestCaseData> NextNumTestCases 
		{
			get 
			{
				yield return new TestCaseData (
					10,
					new int [] { 1, 2 },
					new float [] { 0.25f, 0.75f },
					new Dictionary<int, int> { { 1, 3 }, { 2, 7 } },
					2).SetName ("2Numbers10ThrowsSkewedProbability");

				yield return new TestCaseData (
					10,
					new int [] { 1, 2 },
					new float [] { 0.5f, 0.5f },
					new Dictionary<int, int> { { 1, 5 }, { 2, 5 } },
					2).SetName ("2Numbers10ThrowsEqualProbability");
				
				yield return new TestCaseData (
					10,
					new int [] { 1, 2, 3 },
					new float [] { 0.25f, 0.25f, 0.5f },
					new Dictionary<int, int> { { 1, 3 }, { 2, 2 }, { 3, 5 } },
					2).SetName ("3Numbers10ThrowsSkewedProbability");

				yield return new TestCaseData (
					100,
					new int [] { 1, 2 },
					new float [] { 0.5f, 0.5f },
					new Dictionary<int, int> { { 1, 50 }, { 2, 50 } },
					10).SetName ("2Numbers100ThrowsEqualProbability");

				yield return new TestCaseData (
					100,
					new int [] { 1, 2, 3 },
					new float [] { 0.2f, 0.3f, 0.5f },
					new Dictionary<int, int> { { 1, 20 }, { 2, 30 }, { 3, 50 } },
					10).SetName ("3Numbers100ThrowsSkewedProbability");

				yield return new TestCaseData (
					1000,
					new int [] { 1, 2, 3 },
					new float [] { 0.2f, 0.3f, 0.5f },
					new Dictionary<int, int> { { 1, 250 }, { 2, 250 }, { 3, 500 } },
					100).SetName ("3Numbers1000ThrowsSkewedProbability");
			}
		}

		public static IEnumerable<TestCaseData> FillTestCases 
		{
			get 
			{
				yield return new TestCaseData (new [] { 10, 20, 30 }, new [] { 2, 3, 5 }, 10)
					.Returns (new [] { 10, 10, 20, 20, 20, 30, 30, 30, 30, 30 })
					.SetName ("3Integers_ExtrapolationOf10");
			}
		}

		public static IEnumerable<TestCaseData> ExtrapolateProbabilitiesTestCases 
		{
			get 
			{
				yield return new TestCaseData (
					new float [] { 0.3f, 0.4f, 0.3f },
					10)
						.Returns (new int [] { 3, 4, 3 })
						.SetName ("3ProbabilitiesNoRoundingOrTruncating");

				yield return new TestCaseData (
					new float [] { 0.25f, 0.25f, 0.5f },
					10)
						.Returns (new int [] { 3, 2, 5 })
						.SetName ("3Probabilities2WithTruncating_ShouldRoundOnlyOne");

				yield return new TestCaseData (
					new float [] { 0.24f, 0.24f, 0.24f, 0.24f, 0.04f },
					10)
						.Returns (new int [] { 3, 2, 3, 2, 0 })
						.SetName ("5ProbabilitiesAllWithTruncating_TruncatesEveryAlternateUntilReachedExtrapolationAmount");

				yield return new TestCaseData (
					new float [] { 0.24f, 0.5f, 0.16f, 0.1f },
					10)
						.Returns (new int [] { 3, 5, 1, 1 })
						.SetName ("4ProbabilitiesSomeWithTruncating_TruncatesEveryAlternateOne");
			}
		}

		[Test]
		public void Constructor_NoNumbers_ThrowsException()
		{
			int [] numbers = new int [] { };
			float [] probabilities = new float [] { 0.5f, 0.5f };
			Assert.Throws<InvalidInputException>(() => new RandomGen(numbers, probabilities));
		}

		[Test]
		public void Constructor_NoProbabilities_ThrowsException()
		{
			int [] numbers = new int [] { 1, 2 };
			float [] probabilities = new float [] { };
			Assert.Throws<InvalidInputException>(() => new RandomGen(numbers, probabilities));
		}

		[Test]
		public void Constructor_NumProbabilitiesNotEqualToRandomNums_ThrowsException()
		{
			int [] numbers = new int [] { 1, 2 };
			float [] probabilities = new float [] { 0.5f };
			Assert.Throws<InvalidInputException>(() => new RandomGen(numbers, probabilities));
		}

		[Test]
		public void Constructor_ProbabilitiesDoNotSumToOne_ThrowsException()
		{
			int [] numbers = new int [] { 1, 2 };
			float [] probabilities = new float [] { 0.5f, 0.7f };
			Assert.Throws<InvalidInputException>(() => new RandomGen(numbers, probabilities));			
		}

		[Test]
		public void Constructor_NotAllProbabilitiesAreBetweenZeroAndOne_ThrowsException ()
		{
			int [] numbers = new int [] { 1, 2 };
			float [] probabilities = new float [] { -0.7f, 1.7f };
			Assert.Throws<InvalidInputException>(() => new RandomGen (numbers, probabilities));			
		}

		[Test, TestCaseSource ("NextNumTestCases")]
		public void NextNum (
			int numThrows,
			int[] randomNumbers,
			float[] probabilities,
			Dictionary<int, int> expectedCountsPerNum,
			int marginOfError)
		{
			var randomGen = new RandomGen(randomNumbers, probabilities);
			Dictionary<int, int> actualCountsPerNum = new Dictionary<int, int>();

			for (int i = 0; i < numThrows; i++) 
			{
				int nextNum = randomGen.NextNum();
				if (!actualCountsPerNum.ContainsKey(nextNum)) 
				{
					actualCountsPerNum[nextNum] = 0;
				}

				actualCountsPerNum[nextNum]++;
			}

			if (!ResultsMatch(expectedCountsPerNum, actualCountsPerNum, marginOfError))
			{
				Assert.Fail(string.Format(
					"Did not generate expected numbers. Expected: {0}, Actual: {1}]",
					this.PrintDictionary(expectedCountsPerNum),
					this.PrintDictionary(actualCountsPerNum)));
			}

			Assert.Pass();
		}

		[Test, TestCaseSource ("ExtrapolateProbabilitiesTestCases")]
		public int [] ExtrapolateProbabilitiesTests(float[] probabilities, int extrapolationAmount)
		{
			return RandomGen.ExtrapolateProbabilities (probabilities, extrapolationAmount);
		}

		[Test, TestCaseSource ("FillTestCases")]
		public int [] FillByProbabilitiesTestCases (int [] numbers, int [] probabilities, int extrapolationAmount)
		{
			return RandomGen.FillByProbabilities (numbers, probabilities, extrapolationAmount);
		}

		private bool ResultsMatch(Dictionary<int, int> expected, Dictionary<int, int> actual, int marginOfError)
		{
			foreach (var key in expected.Keys) 
			{
				if (Math.Abs(expected[key] - actual[key]) > marginOfError) 
				{
					return false;
				}
			}

			return true;
		}

		private string PrintDictionary(Dictionary<int, int> dictionary)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("{ ");

			foreach (var key in dictionary.Keys) 
			{
				sb.Append (string.Format ("[{0}:{1}],", key, dictionary [key]));
			}

			sb.Append(" }");

			return sb.ToString();
		}
	}
}
