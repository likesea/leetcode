using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{
    public class InverseBinaryTree
    {
        public void InverseTree(Node root)
        {
            if(root==null) return ;
            InverseTree(root.Left);
            InverseTree(root.Right);
            var temp = root.Left;
            root.Left = root.Right;
            root.Right = temp;
           
        }
    }

    public class Node
    {
        public int Val { get; set; }
        public Node Left { get; set; } 
        public Node Right { get; set; }
    }
}
