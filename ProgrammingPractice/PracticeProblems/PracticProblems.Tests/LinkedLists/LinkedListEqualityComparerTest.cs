using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class LinkedListEqualityComparerTest
	{
		public static IEnumerable<TestCaseData> TestCases 
		{
			get 
			{
				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (Enumerable.Empty<int> ()),
					LinkedListBuilder<int>.Build (Enumerable.Empty<int> ()))
						.Returns (true)
						.SetName ("EmptyEnumerable");

			/*	yield return new TestCaseData (
					LinkedListBuilder<int>.Build (null),
					LinkedListBuilder<int>.Build (null))
						.Returns (false)
						.SetName ("NullEnumerables");*/

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1 }),
					LinkedListBuilder<int>.Build (Enumerable.Empty<int> ()))
						.Returns (false)
						.SetName ("SingleElementInFirstAndEmptySecond");

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1 }),
					LinkedListBuilder<int>.Build (new [] { 1 }))
						.Returns (true)
						.SetName ("SingleElementInFirstAndSecond");

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1, 2, 3 }),
					LinkedListBuilder<int>.Build (new [] { 1, 2, 3 }))
						.Returns (true)
						.SetName ("BothEnumerablesInSameOrder");

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1, 2, 3 }),
					LinkedListBuilder<int>.Build (new [] { 3, 2, 1 }))
						.Returns (true)
						.SetName ("BothEnumerablesSameButDifferentOrder");

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1, 2 }),
					LinkedListBuilder<int>.Build (new [] { 1, 2, 3 }))
						.Returns (false)
						.SetName ("FirstIsSubsetOfSecond");

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1, 2, 3 }),
					LinkedListBuilder<int>.Build (new [] { 3, 1 }))
						.Returns (false)
						.SetName ("SecondIsSubsetOfFirst");
			}
		}

		[Test, TestCaseSource ("TestCases")]
		public bool Equals (LinkedList<int> first, LinkedList<int> second)
		{
			return new LinkedListEqualityComparer ().Equals (first, second);
		}
	}
}
