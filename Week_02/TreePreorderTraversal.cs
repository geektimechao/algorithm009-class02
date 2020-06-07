using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2
{
    public class TreePreorderTraversal
    {
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        public static IList<int> Preorder(Node root)
        {
            if (root == null) return Array.Empty<int>();
            var res = new List<int>();
            Stack<Node> s = new Stack<Node>();
            s.Push(root);
            while (s.Count > 0)
            {
                var temp = s.Pop();
                res.Add(temp.val);
                foreach (var item in Enumerable.Reverse(temp.children))
                {
                        s.Push(item);
                }
            }
            return res;
        }
    }
}
