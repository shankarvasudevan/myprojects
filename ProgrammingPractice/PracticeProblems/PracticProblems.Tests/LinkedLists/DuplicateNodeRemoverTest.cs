using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class DuplicateNodeRemoverTest
	{
		public static IEnumerable<TestCaseData> TestCases 
		{
			get 
			{
				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1, 2, 3, 2, 4 }), 
					LinkedListBuilder<int>.Build (new [] { 1, 2, 3, 4 }))
					.SetName("MultipleDifferenceNumbersWithOneDuplicate");
				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1, 1 }), 
					LinkedListBuilder<int>.Build (new [] { 1 }))
					.SetName("SingleNumberDuplicatedOnce");
				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (Enumerable.Empty<int> ()), 
					LinkedListBuilder<int>.Build (Enumerable.Empty<int> ()))
					.SetName ("EmptyLinkedList");
				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1, 1, 2, 2, 3, 3 }), 
					LinkedListBuilder<int>.Build (new [] { 1, 2, 3 }))
					.SetName ("MultipleNumbersDuplicatedTwice");
				yield return new TestCaseData (
					LinkedListBuilder<int>.Build (new [] { 1, 2, 3 }), 
					LinkedListBuilder<int>.Build (new [] { 1, 2, 3 }))
					.SetName ("MultipleNumbersNoDuplicates");
			}
		}


		[Test, TestCaseSource("TestCases")]
		public void RemoveWithBuffer_TestCases(LinkedList<int> original, LinkedList<int> expected)
		{
			LinkedList<int> actual = DuplicateNodeRemover.RemoveWithBuffer (original);
			Assert.IsTrue (
				new LinkedListEqualityComparer ().Equals (actual, expected),
			    PrintError(actual, expected));
		}

		[Test, TestCaseSource ("TestCases")]
		public void RemoveWithoutBuffer_TestCases (LinkedList<int> original, LinkedList<int> expected)
		{
			LinkedList<int> actual = DuplicateNodeRemover.RemoveWithoutBuffer (original);
			Assert.IsTrue (
				new LinkedListEqualityComparer ().Equals (actual, expected),
				PrintError (actual, expected));
		}

		static string PrintError (LinkedList<int> actual, LinkedList<int> expected)
		{
			return string.Format (
				"Expected: {0}, Actual:D {1}", 
				LinkedListPrinter<int>.Print(expected), 
				LinkedListPrinter<int>.Print(actual)); 
		}
	}
}
