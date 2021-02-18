using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class ContainerWithMostWaterTests
    {

        [Test]
        [TestCase(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [TestCase(new[] { 1, 1 }, 1)]
        [TestCase(new[] { 4, 3, 2, 1, 4 }, 16)]
        [TestCase(new[] { 1, 2, 1 }, 2)]
        public void ContainerWithMostWaterTest(int[] input, int expected)
        {
            var containerWithMostWater = new ContainerWithMostWater();

            var actual = containerWithMostWater.MaxAreaNormalSolution(input);

            Assert.That(actual, Is.EqualTo(expected));

            actual = containerWithMostWater.MaxAreaBetterSolution(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
