using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_BTree_Inorder_Traversal
{
    /*
    094_BTree_Inorder_Traversal
    2021/08/09

    ******************************
    Preorder: root->left->right
    Inorder: left->root->right
    Postorder: left->right->root
    *****************************

    Given the root of a binary tree, return the ineorder traversal of its nodes' values.

    Example 1:
    Input: root = [1,null,2,3]
    Output: [1,3,2]
    
    Example 2:
    Input: root = []
    Output: []
    
    Example 3:
    Input: root = [1]
    Output: [1]
    
    Example 4:
    Input: root = [1,2]
    Output: [2,1]
    
    Example 5:
    Input: root = [1,null,2]
    Output: [1,2]
    */
    public class BTree_Inorder_Traversal
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
        public static IList<int> InorderTraversal_1(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null) return result;

            Stack<TreeNode> s = new Stack<TreeNode>();

            while (root != null || s.Count != 0)
            {
                while (root != null)
                {
                    s.Push(root);
                    root = root.left;

                }
                result.Add(s.Peek().val);
                root = s.Pop().right;
            }
            return result;
        }

        // Recursive
        // Time complexity: O(n)
        // Space complexity: O(n))
        public static IList<int> InorderTraversal_2(TreeNode root)
        {
            IList<int> result = new List<int>();
            Inorder(root, result);

            return result;
        }

        public static void Inorder(TreeNode root, IList<int> ret)
        {
            if (root == null) return;

            Inorder(root.left, ret);
            ret.Add(root.val);
            Inorder(root.right, ret);
        }

        // run code should change this function name with Main instead of fun_Main
        static void Main(string[] args)
        {
            Console.WriteLine("-----Binary Tree_Inorder_Traversal_1-----");
            TreeNode t1_1 = new TreeNode(1);
            t1_1.right = new TreeNode(2);
            t1_1.right.left = new TreeNode(3);
            Console.WriteLine(string.Join(", ", InorderTraversal_1(t1_1)));

            TreeNode t1_2 = new TreeNode();
            Console.WriteLine(string.Join(", ", InorderTraversal_1(t1_2)));

            TreeNode t1_3 = new TreeNode(1);
            Console.WriteLine(string.Join(", ", InorderTraversal_1(t1_3)));

            TreeNode t1_4 = new TreeNode(1);
            t1_4.left = new TreeNode(2);
            Console.WriteLine(string.Join(", ", InorderTraversal_1(t1_4)));

            TreeNode t1_5 = new TreeNode(1);
            t1_5.right = new TreeNode(2);
            Console.WriteLine(string.Join(", ", InorderTraversal_1(t1_5)));

            Console.WriteLine("-----Binary Tree Inorder Traversal_2-----");
            TreeNode t2_1 = new TreeNode(1);
            t2_1.right = new TreeNode(2);
            t2_1.right.left = new TreeNode(3);
            Console.WriteLine(string.Join(", ", InorderTraversal_2(t2_1)));

            TreeNode t2_2 = new TreeNode();
            Console.WriteLine(string.Join(", ", InorderTraversal_2(t2_2)));

            TreeNode t2_3 = new TreeNode(1);
            Console.WriteLine(string.Join(", ", InorderTraversal_2(t2_3)));

            TreeNode t2_4 = new TreeNode(1);
            t2_4.left = new TreeNode(2);
            Console.WriteLine(string.Join(", ", InorderTraversal_2(t2_4)));

            TreeNode t2_5 = new TreeNode(1);
            t2_5.right = new TreeNode(2);
            Console.WriteLine(string.Join(", ", InorderTraversal_2(t2_5)));
        }
    }
}