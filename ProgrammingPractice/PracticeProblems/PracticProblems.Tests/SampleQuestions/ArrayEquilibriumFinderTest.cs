using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PracticeProblems.SampleQuestions;

namespace PracticProblems.Tests.SampleQuestions
{
    [TestFixture]
    public class ArrayEquilibriumFinderTest
    {
        public IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new int[] { -1, 2, -2, 3, 4, -2, 0, 1 },
                    new int[] { 0 }).SetName("ExampleCase");   
            }
        }

        [Test, TestCaseSource("TestCases")]
        public void Find(IEnumerable<int> input, IEnumerable<int> validEquilibriums)
        {
            var arrayEquilibriumFinder = new ArrayEquilibriumFinder();
            var result = arrayEquilibriumFinder.Find(input.ToArray());
            Assert.That(validEquilibriums, Contains.Item(result));
        }
    }
}
