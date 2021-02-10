using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class UnivaluedTree
    {
        int val;
        bool returnValue = true;
        public bool IsUnivalTree(TreeNode root)
        {
            val = root.val;
            return IsSameValue(root);
        }

        public bool IsSameValue(TreeNode root)
        {
            if (root != null && returnValue)
            {
                if (root.val != val)
                {
                    returnValue = false;
                }
                IsSameValue(root.right);
                IsSameValue(root.left);
            }
            return returnValue;
        }
    }
}
