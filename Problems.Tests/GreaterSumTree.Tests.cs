using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class GreaterSumTreeTests
    {

        [Test]
        public void ConvertBSTTest()
        {
            var greaterSumTree = new GreaterSumTree();
            TreeNode treeNode = new TreeNode(1, new TreeNode(0), new TreeNode(2));

            var actual = greaterSumTree.ConvertBST(treeNode);
            var expected = new TreeNode(3, new TreeNode(3), new TreeNode(2));

            Assert.That(actual.val, Is.EqualTo(expected.val));
        }
    }
}
