using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class AdjacencyCheckerTest
	{
		public static IEnumerable<TestCaseData> TestCases 
		{
			get 
			{
				yield return new TestCaseData (new int[] { 1, 4, 7, 3, 3, 5 })
					.Returns (4)
					.SetName ("FirstExample");

				yield return new TestCaseData (new int [] { 0, 3, 3, 7, 5, 3, 11, 1 })
					.Returns (7)
					.SetName ("SecondExample");

				yield return new TestCaseData (new int [] { 0, 3, 3, 7, 5, 1, 3, 11, 1 })
					.Returns (8)
					.SetName ("ThirdExample");
			}
		}

		[Test, TestCaseSource ("TestCases")]
		public int AdjacencyTests (int [] a)
		{
			return new AdjacencyChecker().Check(a);
		}
	}
}
