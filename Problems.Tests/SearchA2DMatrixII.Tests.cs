using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class SearchA2DMatrixIITests
    {

        [Test]
        public void SearchA2DMatrixIITest()
        {
            int[][] matrix = new[]
            {
                new[] { 1, 4, 7, 11, 15 },
                new[] { 2, 5, 8, 12, 19 },
                new[] { 3, 6, 9, 16, 22 },
                new[] { 10, 13, 14, 17, 24 },
                new[] { 18, 21, 23, 26, 30 }
            };

            var searchA2DMatrixII = new SearchA2DMatrixII();

            var actual = searchA2DMatrixII.SearchMatrix(matrix, 5);

            bool expected = true;

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
