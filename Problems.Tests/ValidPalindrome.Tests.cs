using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class ValidPalindromeTests
    {

        [Test]
        [TestCase(".,", true)]
        [TestCase("A man, a plan, a canal: Panama", true)]
        [TestCase("race a car", false)]
        public void ValidPalindromeTest(string s, bool expected)
        {
            var validPalindrome = new ValidPalindrome();

            var actual = validPalindrome.IsPalindrome(s);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("aba", true)]
        [TestCase("abca", true)]
        public void TryValidPalindromeTest(string s, bool expected)
        {
            var validPalindrome = new ValidPalindrome();

            var actual = validPalindrome.TryPalindromeByRemovingOneChar(s);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
