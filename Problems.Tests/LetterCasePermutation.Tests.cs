using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class LetterCasePermutationTests
    {

        [Test]
        [TestCase("a1b2", new[] { "a1b2", "a1B2", "A1b2", "A1B2" })]
        [TestCase("3z4", new[] { "3z4", "3Z4" })]
        [TestCase("12345", new[] { "12345" })]
        [TestCase("0", new[] { "0" })]
        public void LetterCasePermutationTest(string s, string[] expected)
        {
            var letterCasePermutation = new LetterCasePermutation();

            var actual = letterCasePermutation.GetLetterCasePermutation(s);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
