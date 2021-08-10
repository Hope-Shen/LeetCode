using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Invert_Binary_Tree
{
    /*
    226_Invert_Binary_Tree
    2021/08/10

    Given the root of a binary tree, invert the tree, and return its root.

    Example 1:
    Input: root = [4,2,7,1,3,6,9]
    Output: [4,7,2,9,6,3,1]
    
    Example 2:
    Input: root = [2,1,3]
    Output: [2,3,1]
    
    Example 3:
    Input: root = []
    Output: []

    */
    public class Invert_Binary_Tree
    {
        //Definition for a binary tree node.
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

        // Iteratively solution
        // Time complexity: O(n)
        // Space complexity: O(n))
        public static TreeNode InvertTree_1(TreeNode root)
        {
            if (root == null) return root;

            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);

            while (s.Count > 0)
            {
                TreeNode currTree = s.Pop();
                TreeNode temp = currTree.right;
                currTree.right = currTree.left;
                currTree.left = temp;

                if (currTree.right != null)
                {
                    s.Push(currTree.right);
                }
                if (currTree.left != null)
                {
                    s.Push(currTree.left);
                }
            }
            return root;
        }

        // Recursive solution
        // Time complexity: O(n)
        // Space complexity: O(n))
        public static TreeNode InvertTree_2(TreeNode root)
        {
            if (root == null) return root;

            TreeNode left = InvertTree_2(root.left);
            TreeNode right = InvertTree_2(root.right);

            //swap left <-> right
            root.left = right;
            root.right = left;

            return root;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Invert BinaryTree_1-----");
            TreeNode t1_1 = new TreeNode(2);
            t1_1.left = new TreeNode(1);
            t1_1.right = new TreeNode(3);
            TreeNode result1_1 = InvertTree_1(t1_1);

            TreeNode t1_2 = new TreeNode(4);
            t1_2.left = new TreeNode(2);
            t1_2.right = new TreeNode(7);
            t1_2.left.left = new TreeNode(1);
            t1_2.left.right = new TreeNode(3);
            t1_2.right.right = new TreeNode(6);
            t1_2.right.right = new TreeNode(9);
            TreeNode result1_2 = InvertTree_1(t1_2);

            TreeNode t1_3 = new TreeNode();
            TreeNode result1_3 = InvertTree_1(t1_3);

            TreeNode t1_4 = new TreeNode(1);
            t1_4.right = new TreeNode(2);
            TreeNode result1_4 = InvertTree_1(t1_4);

            Console.WriteLine("-----Invert BinaryTree_2-----");
            TreeNode t2_1 = new TreeNode(2);
            t2_1.left = new TreeNode(1);
            t2_1.right = new TreeNode(3);
            TreeNode result2_1 = InvertTree_2(t2_1);

            TreeNode t2_2 = new TreeNode(4);
            t2_2.left = new TreeNode(2);
            t2_2.right = new TreeNode(7);
            t2_2.left.left = new TreeNode(1);
            t2_2.left.right = new TreeNode(3);
            t2_2.right.right = new TreeNode(6);
            t2_2.right.right = new TreeNode(9);
            TreeNode result2_2 = InvertTree_2(t2_2);

            TreeNode t2_3 = new TreeNode();
            TreeNode result2_3 = InvertTree_2(t2_3);

            TreeNode t2_4 = new TreeNode(1);
            t2_4.right = new TreeNode(2);
            TreeNode result2_4 = InvertTree_2(t2_4);
        }
    }
}