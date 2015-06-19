using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class FlattenBinaryTreetoLinkedList
    {
        private List<TreeNode> list = new List<TreeNode>(); 
        public void Flatten(TreeNode root)
        {
            if (root == null) return;
            Sol(root);
            root.left = null;
            var temp = root;
            list.RemoveAt(0);
            foreach (var treeNode in list)
            {
                temp.right = treeNode;
                treeNode.left = null;
                temp = temp.right;
            }
           
        }
        private void Sol(TreeNode root)
        {
            if (root == null) return;
            list.Add(root);
            Sol(root.left);
            Sol(root.right);
        }
    }
}
