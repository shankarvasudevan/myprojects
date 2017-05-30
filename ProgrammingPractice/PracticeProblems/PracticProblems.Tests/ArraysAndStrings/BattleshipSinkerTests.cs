using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class BattleshipSinkerTests
	{
		public static IEnumerable<TestCaseData> TestCases 
		{
			get 
			{
				yield return new TestCaseData (4, @"1B 2C,2D 4D", @"2B 2D 3D 4D")
					.Returns ("1,1")
					.SetName ("FirstExample");

				yield return new TestCaseData (3, @"1A 1B,2C 2C", @"1B")
					.Returns ("0,1")
					.SetName ("SecondExample");

				yield return new TestCaseData (12, @"1A 2A,12A 12A", @"12A")
					.Returns ("1,0")
					.SetName ("ThirdExample");
			}
		}

		[Test, TestCaseSource("TestCases")]
		public string SinksAndHitsTests (int n, string s, string t)
		{
			return new BattleshipSinker ().SinksAndHits (n, s, t);
		}
	}
}
