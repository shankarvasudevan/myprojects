using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class NthToLastLinkedListElementFinderTest
	{
		public static IEnumerable<TestCaseData> TestCases 
		{
			get 
			{
				yield return new TestCaseData (
					new LinkedList<int> (),
					1,
					null)
						.SetName ("EmptyList_ReturnsNull");

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1 }),
					1,
					new LinkedListNode<int> (1))
						.SetName ("SingleElementNEquals1_ReturnsOnlyElement");

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1, 2 }),
					1,
					new LinkedListNode<int> (2))
						.SetName ("TwoElementsNEquals1_ReturnsSecondElement");

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1, 2, 3, 4, 5 }),
					2,
					new LinkedListNode<int> (4))
						.SetName ("MultipleElementsNEquals2_ReturnsSecondLastElement");

				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1, 2, 3, 4, 5 }),
					5,
					new LinkedListNode<int> (1))
						.SetName ("MultipleElementsNEqualsLength_ReturnsFirstElement");
			}
		}
		
		[Test, TestCaseSource("TestCases")]
		public void Find(LinkedList<int> inputList, int n, LinkedListNode<int> expected)
		{
			LinkedListNode<int> actual = NthToLastLinkedListElementFinder.Find (inputList, n);
			Assert.IsTrue (
				new LinkedListNodeEqualityComparer<int> ().Equals (actual, expected),
				string.Format ("Expected [{0}] but was [{1}]", expected, actual));
		}
	}
}
