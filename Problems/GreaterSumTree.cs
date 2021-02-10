using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    //   Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class GreaterSumTree
    {
        int sum = 0;
        public TreeNode ConvertBST(TreeNode root)
        {
            if (root is { })
            {
                ConvertBST(root.right);
                root.val += sum;
                sum = root.val;
                ConvertBST(root.left);
            }
            return root;
        }
    }
}
