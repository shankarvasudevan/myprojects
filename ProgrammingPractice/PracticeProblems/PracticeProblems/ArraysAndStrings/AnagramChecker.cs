using System;
namespace PracticeProblems
{
	public static class AnagramChecker
	{
		public static bool Check (string strA, string strB)
		{
			if (strA == null || strB == null) 
			{
				return false;
			}

			int[] letterCountA = new int[256];
			int[] letterCountB = new int[256];

			foreach (char c in strA.ToLower()) 
			{
				int asciiVal = (int)c;
				letterCountA [asciiVal]++;
			}

			foreach (char c in strB.ToLower()) 
			{
				int asciiVal = (int)c;
				letterCountB [asciiVal]++;
			}

			for (int i = 0; i < 256; i++) 
			{
				if (letterCountA [i] != letterCountB [i]) 
				{
					return false;
				}
			}

			return true;
		}
	}
}
