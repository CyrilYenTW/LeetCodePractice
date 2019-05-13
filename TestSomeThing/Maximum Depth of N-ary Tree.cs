using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Maximum_Depth_of_N_ary_Tree
    {
        public class Solution
        {
            public Solution()
            {
                var a = new Node();

                a.children = new List<Node>();
                a.children.Add(new Node());
                a.children.Add(new Node());
                a.children.Add(new Node());
                a.children[0].children = new List<Node>();
                a.children[0].children.Add(new Node());
                a.children[0].children.Add(new Node());
                a.children[1].children = new List<Node>();
                a.children[1].children.Add(new Node());

                MaxDepth3(a);
            }

            public int MaxDepth(Node root)
            {
                if (root == null)
                {
                    return 0;
                }

                return this.getDepth(root, 1);
            }

            public int getDepth(Node node, int depthCount)
            {
                if (node.children.Count == 0)
                {
                    return depthCount;
                }

                var result = depthCount;

                foreach(var nextNode in node.children)
                {
                    result = Math.Max(result, getDepth(nextNode, depthCount + 1));
                }

                return result;
            }

            public int MaxDepth2(Node root)
            {
                if (root == null)
                {
                    return 0;
                }

                var depth = 1;

                var childrens = GetChildrens(root.children);

                while(childrens.Count > 0)
                {
                    depth++;

                    var newChildrens = new List<Node>();

                    foreach(var chil in childrens)
                    {
                        if (chil.children == null)
                        {
                            break;
                        }

                        newChildrens.AddRange(GetChildrens(chil.children));
                    }

                    childrens = newChildrens;
                }

                return depth;
            }

            public List<Node> GetChildrens(IList<Node> nodes)
            {
                return nodes.ToList();
            }

            public int MaxDepth3(Node root)
            {
                if (root == null)
                {
                    return 0;
                }

                var depth = 0;

                var q = new Queue<Node>();

                q.Enqueue(root);

                while(q.Count > 0)
                {
                    depth++;

                    var counter = q.Count;

                    for (int i = 0; i < counter; i++)
                    {
                        var temp = q.Dequeue();

                        if (temp == null || temp.children == null)
                        {
                            continue;
                        }

                        foreach(var chil in temp.children)
                        {
                            q.Enqueue(chil);
                        }
                    }
                }

                return depth;
            }
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
