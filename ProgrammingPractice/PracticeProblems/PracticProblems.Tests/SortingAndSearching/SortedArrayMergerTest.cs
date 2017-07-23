using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems;
using PracticeProblems.SortingAndSearching;

namespace PracticProblems.Tests.SortingAndSearching
{
    [TestFixture]
    public class SortedArrayMergerTest
    {
        private SortedArrayMerger merger;

        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(FromEnumerable(new[] { 2 }, 2), new[] { 1 })
                    .Returns(new int[] { 1, 2 })
                    .SetName("OneElementEach");

                yield return new TestCaseData(FromEnumerable(new[] { 1, 3, 5, 7, 9 }, 10), new[] { 2, 4, 6, 8, 10 })
                    .Returns(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })
                    .SetName("OddsAndEvens");

                yield return new TestCaseData(FromEnumerable(new[] { 1, 2, 3 }, 7), new[] { 4, 5, 6, 7 })
                    .Returns(new int[] { 1, 2, 3, 4, 5, 6, 7 })
                    .SetName("FirstArrayBeforeSecond");

                yield return new TestCaseData(FromEnumerable(new[] { 5, 6, 7, 8 }, 8), new[] { 1, 2, 3, 4 })
                    .Returns(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })
                    .SetName("SecondArrayBeforeFirst");
            }
        }

        [SetUp]
        public void Setup()
        {
            this.merger = new SortedArrayMerger();
        }

        [Test, TestCaseSource("TestCases")]
        public int?[] Merge_OneElementEach_MergesCorrectly(int?[] a, int[] b)
        {
            return merger.Merge(a, b);
        }

        private static int?[] FromEnumerable(IEnumerable<int> input, int length)
        {
            int?[] output = new int?[length];
            int i = 0;
            foreach (int num in input)
            {
                output[i++] = num;
            }

            return output;
        }
    }
}
