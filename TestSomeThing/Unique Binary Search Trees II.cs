using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Unique_Binary_Search_Trees_II
    {
        public Unique_Binary_Search_Trees_II()
        {
            var a = this.GenerateTrees(4);
        }


        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n < 1)
            {
                return new List<TreeNode>();
            }

            return Process(1, n);
        }

        public IList<TreeNode> Process(int start, int end)
        {
            IList<TreeNode> list = new List<TreeNode>();

            if (start > end)
            {
                list.Add(null);
                return list;
            }

            for (int i = start; i <= end; i++)
            {
                IList<TreeNode> lefts = this.Process(start, i - 1);
                IList<TreeNode> rights = this.Process(i + 1, end);

                foreach(TreeNode l in lefts)
                {
                    foreach(TreeNode r in rights)
                    {
                        var node = new TreeNode(i);

                        node.left = l;
                        node.right = r;
                        list.Add(node);
                    }
                }
            }

            return list;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
