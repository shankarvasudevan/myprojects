using System;
using NUnit.Framework;
using PracticeProblems.SortingAndSearching;

namespace PracticProblems.Tests.SortingAndSearching
{
    [TestFixture]
    public class CircusTowerGeneratorTest
    {
        private CircusTowerGenerator towerGen;

        [SetUp]
        public void Setup()
        {
            this.towerGen = new CircusTowerGenerator();
        }

        [Test]
        public void Generate_NullInput_ReturnsNullOutput()
        {
            Assert.That(this.towerGen.Generate(null), Is.Null);
        }

        [Test]
        public void Generate_EmptyInput_ReturnsEmptyOutput()
        {
            Assert.That(this.towerGen.Generate(new Tuple<int, int>[] { }), Is.Empty);
        }

        [Test]
        public void Generate_SinglePerson_ReturnsSameOutput()
        {
            var people = new Tuple<int, int>[] { Tuple.Create(170, 70) };
            Assert.That(this.towerGen.Generate(people), Is.EquivalentTo(people));
        }

        [Test]
        public void Generate_TwoPeopleOneShorterAndHeavier_ReturnsBestTowerOfOne()
        {
            var people = new Tuple<int, int>[] { Tuple.Create(170, 70), Tuple.Create(180, 60) };
            Assert.That(this.towerGen.Generate(people), Has.Length.EqualTo(1));
        }

        [Test]
        public void Generate_FivePeople_ReturnsBestTowerOfFour()
        {
            var people = new Tuple<int, int>[]
            {
                Tuple.Create(185, 70),
                Tuple.Create(180, 60),
                Tuple.Create(130, 90),
                Tuple.Create(140, 50),
                Tuple.Create(190, 80)
            };

            var expectedTower = new Tuple<int, int>[]
            {
                Tuple.Create(140, 50),
                Tuple.Create(180, 60),
                Tuple.Create(185, 70),
                Tuple.Create(190, 80)
            };

            Assert.That(this.towerGen.Generate(people), Is.EquivalentTo(expectedTower));
        }
    }
}
