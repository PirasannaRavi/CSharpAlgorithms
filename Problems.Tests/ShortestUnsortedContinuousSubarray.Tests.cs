using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class ShortestUnsortedContinuousSubarrayTests
    {

        [Test]
        [TestCase(new[] { 2, 1 }, 2)]
        [TestCase(new[] { 1 }, 0)]
        [TestCase(new[] { 1, 2, 3, 4 }, 0)]
        [TestCase(new[] { 2, 6, 4, 8, 10, 9, 15 }, 5)]
        public void ShortestUnsortedContinuousSubarrayTest(int[] nums, int expected)
        {
            var shortestUnsortedContinuousSubarray = new ShortestUnsortedContinuousSubarray();

            var actual = shortestUnsortedContinuousSubarray.FindUnsortedSubarray(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
