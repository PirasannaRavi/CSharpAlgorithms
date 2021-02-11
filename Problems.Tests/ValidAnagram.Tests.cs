using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class ValidAnagramTests
    {

        [Test]
        [TestCase("aacc", "ccac", false)]
        [TestCase("anagram", "nagaram", true)]
        [TestCase("anagram", "yagaram", false)]
        [TestCase("anagram", "ayagaram", false)]
        public void ValidAnagramTest(string s, string t, bool expected)
        {
            var validAnagram = new ValidAnagram();

            var actual = validAnagram.IsAnagramBestCase(s, t);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
