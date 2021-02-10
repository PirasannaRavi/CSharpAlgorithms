using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class ShortestDistanceToACharacterTests
    {

        [Test]
        [TestCase("aaab", 'b', new[] { 3, 2, 1, 0 })]
        [TestCase("loveleetcode", 'e', new[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 })]
        public void GetShortestToChar1(string s, char c, int[] expected)
        {
            var shortestDistanceToACharacter = new ShortestDistanceToACharacter();
            var actual = shortestDistanceToACharacter.ShortestToChar(s, c);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
