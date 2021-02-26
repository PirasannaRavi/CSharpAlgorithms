using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class ValidateStackSequencesAlgoTests
    {
        [Test]
        [TestCase(new int[0], new int[0], true)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 }, true)]
        [TestCase(new[] { 0, 2, 1 }, new[] { 0, 1, 2 }, true)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 4, 3, 5, 1, 2 }, false)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 4, 5, 3, 2, 1 }, true)]
        public void ValidateStackSequencesAlgoTest(int[] pushed, int[] popped, bool expected)
        {
            var validateStackSequencesAlgo = new ValidateStackSequencesAlgo();

            var actual = validateStackSequencesAlgo.validateStackSequences(pushed, popped);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
