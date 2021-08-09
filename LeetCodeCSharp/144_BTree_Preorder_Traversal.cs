using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_BTree_Preorder_Traversal
{
    /*
    114_BTree_Preorder_Traversal
    2021/08/09

    Given the root of a binary tree, return the preorder traversal of its nodes' values.

    Example 1:
    Input: root = [1,null,2,3]
    Output: [1,2,3]
    
    Example 2:
    Input: root = []
    Output: []
    
    Example 3:
    Input: root = [1]
    Output: [1]
    
    Example 4:
    Input: root = [1,2]
    Output: [1,2]
    
    Example 5:
    Input: root = [1,null,2]
    Output: [1,2]
    */
    public class BTree_Preorder_Traversal
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
        public static IList<int> PreorderTraversal_1(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null) return result;

            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);

            while (s.Count != 0)
            {
                result.Add(s.Peek().val);
                TreeNode currTree = s.Pop();

                if (currTree.right != null)
                {
                    s.Push(currTree.right);
                }
                if (currTree.left != null)
                {
                    s.Push(currTree.left);
                }
            }
            return result;
        }

        // Recursive
        // Time complexity: O(n)
        // Space complexity: O(n))
        public static IList<int> PreorderTraversal_2(TreeNode root)
        {
            IList<int> result = new List<int>();
            Preorder(root, result);
            
            return result;
        }

        public static void Preorder(TreeNode root, IList<int> ret)
        {
            if(root == null) return;

            ret.Add(root.val);
            Preorder(root.left, ret);
            Preorder(root.right, ret);
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Binary Tree Preorder Traversal_1-----");
            TreeNode t1_1 = new TreeNode(1);
            t1_1.right = new TreeNode(2);
            t1_1.right.right = new TreeNode(3);
            Console.WriteLine(string.Join(", ", PreorderTraversal_1(t1_1)));

            TreeNode t1_2 = new TreeNode();
            Console.WriteLine(string.Join(", ", PreorderTraversal_1(t1_2)));

            TreeNode t1_3 = new TreeNode(1);
            t1_3.left = new TreeNode(2);
            Console.WriteLine(string.Join(", ", PreorderTraversal_1(t1_3)));

            TreeNode t1_4 = new TreeNode(1);
            t1_4.right = new TreeNode(2);
            Console.WriteLine(string.Join(", ", PreorderTraversal_1(t1_4)));

            Console.WriteLine("-----Binary Tree Preorder Traversal_2-----");
            TreeNode t2_1 = new TreeNode(1);
            t2_1.right = new TreeNode(2);
            t2_1.right.right = new TreeNode(3);
            Console.WriteLine(string.Join(", ", PreorderTraversal_2(t2_1)));

            TreeNode t2_2 = new TreeNode();
            Console.WriteLine(string.Join(", ", PreorderTraversal_1(t2_2)));

            TreeNode t2_3 = new TreeNode(1);
            t2_3.left = new TreeNode(2);
            Console.WriteLine(string.Join(", ", PreorderTraversal_1(t2_3)));

            TreeNode t3_4 = new TreeNode(1);
            t3_4.right = new TreeNode(2);
            Console.WriteLine(string.Join(", ", PreorderTraversal_1(t3_4)));

        }
    }
}