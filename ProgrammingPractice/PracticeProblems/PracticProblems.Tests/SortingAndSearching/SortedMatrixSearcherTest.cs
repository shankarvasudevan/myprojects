using System;
using NUnit.Framework;
using PracticeProblems.SortingAndSearching;

namespace PracticProblems.Tests.SortingAndSearching
{
    [TestFixture]
    public class SortedMatrixSearcherTest
    {
        private SortedMatrixSearcher searcher;

        [SetUp]
        public void Setup()
        {
            this.searcher = new SortedMatrixSearcher();
        }

        [Test]
        public void Find_NullInput_ReturnsNull()
        {
            Assert.That(this.searcher.Find(null, 7), Is.Null);
        }

        [Test]
        public void Find_EmptyInput_ReturnsNull()
        {
            Assert.That(this.searcher.Find(new int[,]{}, 8), Is.Null);
        }

        [Test]
        public void Find_OneByOneMatrixWithTargetValue_ReturnsCorrectCell()
        {
            int[,] input = { { 8 } };
            Tuple<int, int> expectedResult = Tuple.Create(0, 0);
            Assert.That(this.searcher.Find(input, 8), Is.EqualTo(expectedResult));
        }

        [Test]
        public void Find_OneByOneMatrixWithoutTargetValue_ReturnsNull()
        {
			int[,] input = { { 8 } };
			Assert.That(this.searcher.Find(input, 7), Is.Null);
        }

        [Test]
        public void Find_FiveByFiveMatrixWithoutTargetValue_ReturnsNull()
        {
            int[,] input = 
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25}
            };

			Assert.That(this.searcher.Find(input, 27), Is.Null);
        }

		[Test]
		public void Find_FiveByFiveMatrixWithTargetValue_ReturnsNull()
		{
			int[,] input =
			{
				{1, 2, 3, 4, 5},
				{6, 7, 8, 9, 10},
				{11, 12, 13, 14, 15},
				{16, 17, 18, 19, 20},
				{21, 22, 23, 24, 25}
			};

			Tuple<int, int> expectedResult = Tuple.Create(3, 1);
            Assert.That(this.searcher.Find(input, 17), Is.EqualTo(expectedResult));
		}
    }
}
