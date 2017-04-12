using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class AnagramCheckerTest
	{
		public static IEnumerable<TestCaseData> TestCases 
		{
			get 
			{
				yield return new TestCaseData (null, null).Returns (false);
				yield return new TestCaseData (null, "a").Returns (false);
				yield return new TestCaseData ("a", null).Returns (false);
				yield return new TestCaseData (string.Empty, string.Empty).Returns (true);
				yield return new TestCaseData (string.Empty, "a").Returns (false);
				yield return new TestCaseData ("a", string.Empty).Returns (false);
				yield return new TestCaseData ("a", "a").Returns (true);
				yield return new TestCaseData ("abc", "cba").Returns (true);
				yield return new TestCaseData ("hello", "world").Returns (false);
				yield return new TestCaseData ("hello", "Loleh").Returns (true);
			}
		}

		[Test, TestCaseSource("TestCases")]
		public bool Check (string str1, string str2)
		{
			return AnagramChecker.Check (str1, str2);
		}
	}
}
