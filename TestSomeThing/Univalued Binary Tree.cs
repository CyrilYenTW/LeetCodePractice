using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Univalued_Binary_Tree
    {
        public Univalued_Binary_Tree()
        {
            var root = new TreeNode(1);

            IsUnivalTree(root);
        }

        public bool IsUnivalTree(TreeNode root)
        {
            var left = root.left;
            var right = root.right;

            if (left == null && right == null)
            {
                return true;
            }

            if (left == null)
            {
                
                if (root.val != right.val)
                {
                    return false;
                }

                return IsUnivalTree(right);
            }

            if (right == null)
            {
                if (root.val != left.val)
                {
                    return false;
                }

                return IsUnivalTree(left);
            }

            if (right.val != root.val || left.val != root.val)
            {
                return false;
            }

            return IsUnivalTree(left) && IsUnivalTree(right);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
