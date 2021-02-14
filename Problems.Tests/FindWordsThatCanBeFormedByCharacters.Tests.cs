using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class FindWordsThatCanBeFormedByCharactersTests
    {

        [Test]
        public void FindWordsThatCanBeFormedByCharactersTest()
        {
            var findWordsThatCanBeFormedByCharacters = new FindWordsThatCanBeFormedByCharacters();

            var actual = findWordsThatCanBeFormedByCharacters.CountCharacters(new[] { "cat", "bt", "hat", "tree" }, "atach");
            var expected = 6;

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
