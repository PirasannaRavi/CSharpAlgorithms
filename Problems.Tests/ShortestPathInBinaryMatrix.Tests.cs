using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class ShortestPathInBinaryMatrixTests
    {

        [Test]
        public void ShortestPathInBinaryMatrixTest()
        {
            var shortestPathInBinaryMatrix = new ShortestPathInBinaryMatrix();
            int[][] mat = new[] { new[] { 0, 0, 0 }, new int[] { 1, 1, 0 }, new int[] { 1, 1, 0 } };
            var actual = shortestPathInBinaryMatrix.ShortestPathBinaryMatrix(mat);
            var expected = 4;

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
