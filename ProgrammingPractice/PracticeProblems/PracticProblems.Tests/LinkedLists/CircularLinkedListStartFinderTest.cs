using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class CircularLinkedListStartFinderTest
	{
		public static IEnumerable<TestCaseData> TestCases 
		{
			get 
			{
				yield return new TestCaseData (LinkedListBuilder<string>.Build (new [] { "A", "B", "A" }))
					.Returns ("A");

				yield return new TestCaseData (LinkedListBuilder<string>.Build (new [] { "A", "B", "C", "D", "E", "C" }))
					.Returns ("C");

				yield return new TestCaseData (LinkedListBuilder<string>.Build (new [] { "A" }))
					.Returns (null);
			}
		}

		[Test, TestCaseSource ("TestCases")]
		public string FindTestCases (LinkedList<string> linkedList)
		{
			return CircularLinkedListStartFinder.Find (linkedList);
		}
	}
}
