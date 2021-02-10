using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class GetLongestNonRepeatingCharacters
    {

        [Test]
        [TestCase("abcd", 4)]
        [TestCase("dvdc", 3)]
        public void GetLongestNonRepeatingCharacters1(string s, int expectedLength)
        {
            var longestNonRepeatingCharacters = new LongestNonRepeatingCharacters();
            var actualLength = longestNonRepeatingCharacters.GetLongestNonRepeatingCharacters(s);

            Assert.That(actualLength, Is.EqualTo(expectedLength));
        }
    }
}
