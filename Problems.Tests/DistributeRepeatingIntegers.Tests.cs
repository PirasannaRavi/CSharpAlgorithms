using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class DistributeRepeatingIntegersTests
    {

        [Test]
        [TestCase(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2 }, new[] { 4, 3, 4, 3, 3 }, true)]
        [TestCase(new[] { 1, 1, 1, 1, 2, 2, 2 }, new[] { 3, 2, 2 }, true)]
        [TestCase(new[] { 1, 1, 1, 1, 1 }, new[] { 2, 3 }, true)]
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 2 }, false)]
        [TestCase(new[] { 1, 2, 3, 3 }, new[] { 2 }, true)]
        [TestCase(new[] { 1, 1, 2, 2 }, new[] { 2, 2 }, true)]
        [TestCase(new[] { 1, 1, 2, 3 }, new[] { 2, 2 }, false)]
        public void DistributeRepeatingIntegersTest(int[] nums, int[] quantity, bool expected)
        {
            var distributeRepeatingIntegers = new DistributeRepeatingIntegers();

            var actual = distributeRepeatingIntegers.CanDistribute(nums, quantity);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
