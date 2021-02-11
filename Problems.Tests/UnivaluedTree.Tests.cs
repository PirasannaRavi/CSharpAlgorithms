using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class UnivaluedTreeTests
    {

        [Test]
        public void UnivaluedTreeTest()
        {
            var univaluedTree = new UnivaluedTree();
            TreeNode treeNode = new TreeNode(2, new TreeNode(2, new TreeNode(2), new TreeNode(5)), new TreeNode(2));

            var actual = univaluedTree.IsUnivalTree(treeNode);
            var expected = false;

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
