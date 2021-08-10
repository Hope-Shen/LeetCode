using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Maximum_Depth_of_Binary_Tree
{
    /*
    104_Maximum_Depth_of_Binary_Tree
    2021/08/10

    Given the root of a binary tree, return its maximum depth.

    A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

    Example 1:
    Input: root = [3,9,20,null,null,15,7]
    Output: 3
    
    Example 2:
    Input: root = [1,null,2]
    Output: 2
    
    Example 3:
    Input: root = []
    Output: 0
    
    Example 4:
    Input: root = [0]
    Output: 1
    */
    public class Maximum_Depth_of_Binary_Tree
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
        public static int MaxDepth_1(TreeNode root)
        {
            if (root == null) return 0;

            Queue<TreeNode> s_node = new Queue<TreeNode>();
            int depth = 0;
            s_node.Enqueue(root);

            while (s_node.Count > 0)
            {
                int size = s_node.Count;
                while (size > 0)
                {
                    TreeNode curr_node = s_node.Dequeue();

                    if (curr_node.right != null)
                    {
                        s_node.Enqueue(curr_node.right);
                    }
                    if (curr_node.left != null)
                    {
                        s_node.Enqueue(curr_node.left);
                    }
                    size--;
                }
                depth++;
            }
            return depth;
        }

        // Recursive solution
        // Time complexity: O(n)
        // Space complexity: O(n))
        public static int MaxDepth_2(TreeNode root)
        {
            if (root == null) return 0;

            return Math.Max(1 + MaxDepth_2(root.left), 1 + MaxDepth_2(root.right));
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Max Depth_1-----");
            TreeNode t1_1 = new TreeNode(1);
            t1_1.left = new TreeNode(2);
            t1_1.right = new TreeNode(3);
            Console.WriteLine(MaxDepth_1(t1_1));

            TreeNode t1_2 = new TreeNode(3);
            t1_2.left = new TreeNode(9);
            t1_2.right = new TreeNode(20);
            t1_2.right.left = new TreeNode(15);
            t1_2.right.right = new TreeNode(7);
            Console.WriteLine(MaxDepth_1(t1_2));

            TreeNode t1_3 = new TreeNode();
            Console.WriteLine(MaxDepth_1(t1_3));

            TreeNode t1_4 = new TreeNode(1);
            t1_4.left = new TreeNode(2);
            Console.WriteLine(MaxDepth_1(t1_4));

            TreeNode t1_5 = new TreeNode(1);
            t1_5.left = new TreeNode(2);
            t1_5.right = new TreeNode(3);
            t1_5.left.left = new TreeNode(4);
            t1_5.right.left = new TreeNode(5);
            Console.WriteLine(MaxDepth_1(t1_5));

            Console.WriteLine("-----Max Depth_2-----");
            TreeNode t2_1 = new TreeNode(1);
            t2_1.left = new TreeNode(2);
            t2_1.right = new TreeNode(3);
            Console.WriteLine(MaxDepth_2(t2_1));

            TreeNode t2_2 = new TreeNode(3);
            t2_2.left = new TreeNode(9);
            t2_2.right = new TreeNode(20);
            t2_2.right.left = new TreeNode(15);
            t2_2.right.right = new TreeNode(7);
            Console.WriteLine(MaxDepth_2(t2_2));

            TreeNode t2_3 = new TreeNode();
            Console.WriteLine(MaxDepth_2(t2_3));

            TreeNode t2_4 = new TreeNode(1);
            t2_4.left = new TreeNode(2);
            Console.WriteLine(MaxDepth_1(t2_4));

            TreeNode t2_5 = new TreeNode(1);
            t2_5.left = new TreeNode(2);
            t2_5.right = new TreeNode(3);
            t2_5.left.left = new TreeNode(4);
            t2_5.right.left = new TreeNode(5);
            Console.WriteLine(MaxDepth_1(t2_5));
        }
    }
}