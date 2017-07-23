using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems.SortingAndSearching;

namespace PracticProblems.Tests.SortingAndSearching
{
    [TestFixture]
    public class RotatedSortedArraySearcher
    {
        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14 }, 5)
                    .Returns(8)
                    .SetName("ExampleCase");

				yield return new TestCaseData(new int[] { 3, 4, 5, 6, 7, 8, 9, 10, 1, 2 }, 2)
					.Returns(9)
					.SetName("RotatedUnevenlyButTargetAtEnd");

                yield return new TestCaseData(new int[] { 4, 5, 6, 7, 8, 9, 10, 1, 2, 3 }, 1)
                    .Returns(7)
                    .SetName("RotatedUnevenlyButTargetNotAtEndsOrMiddle");
            }
        }

        [Test, TestCaseSource("TestCases")]
        public int FindTestCases(int[] input, int target)
        {
            return new PracticeProblems.SortingAndSearching.RotatedSortedArraySearcher().Find(input, target);
        }
    }
}
