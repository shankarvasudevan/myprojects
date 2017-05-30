using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class LinkedListAdderTests
	{
		public static IEnumerable<TestCaseData> TestCases 
		{
			get 
			{
				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1 }),
					LinkedListBuilder<int>.Build (new [] { 1 }),
					LinkedListBuilder<int>.Build (new [] { 2 }))
						.SetName ("OnePlusOne_ReturnsTwo");

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1 }),
					LinkedListBuilder<int>.Build (new [] { 0 }),
					LinkedListBuilder<int>.Build (new [] { 1 }))
						.SetName ("OnePlusZero_ReturnsOne");

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 0, 1 }),
					LinkedListBuilder<int>.Build (new [] { 1 }),
					LinkedListBuilder<int>.Build (new [] { 1, 1 }))
						.SetName ("TenPlusOne_ReturnsEleven");

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 5, 0, 1 }),
					LinkedListBuilder<int>.Build (new [] { 9, 0, 2 }),
					LinkedListBuilder<int>.Build (new [] { 4, 1, 3 }))
						.SetName ("TwoThreeDigitNumbers_ReturnsThreeDigitNumber");

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 5, 7 }),
					LinkedListBuilder<int>.Build (new [] { 0, 9 }),
					LinkedListBuilder<int>.Build (new [] { 5, 6, 1 }))
						.SetName ("TwoTwoDigitNumbers_ReturnsThreeDigitNumber");
			}
		}

		[Test, TestCaseSource ("TestCases")]
		public void AddTests (LinkedList<int> first, LinkedList<int> second, LinkedList<int> expected)
		{
			LinkedList<int> actual = LinkedListAdder.Add (first, second);
			Assert.IsTrue (
				new LinkedListEqualityComparer ().Equals (actual, expected),
				string.Format (
					"Expected: {0}, Actual: {1}",
					LinkedListPrinter<int>.Print (expected),
					LinkedListPrinter<int>.Print (actual)));
		}
	}
}
