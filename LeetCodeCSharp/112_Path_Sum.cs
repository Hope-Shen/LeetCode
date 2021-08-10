using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Path_Sum
{
    /*
    112_Path_Sum
    2021/08/10

    Given the root of a binary tree and an integer targetSum, 
    return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.

    A leaf is a node with no children.

    Example 1:
    Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
    Output: true
    
    Example 2:
    Input: root = [1,2,3], targetSum = 5
    Output: false
    
    Example 3:
    Input: root = [1,2], targetSum = 0
    Output: false
    */
    public class Path_Sum
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
        public static bool HasPathSum_1(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            Stack<TreeNode> s_node = new Stack<TreeNode>();
            Stack<int> s_sum = new Stack<int>();

            s_node.Push(root);
            s_sum.Push(root.val);

            while (s_node.Count > 0)
            {
                TreeNode curr_node = s_node.Pop();
                int curr_sum = s_sum.Pop();
                if (curr_sum == targetSum && curr_node.left == null && curr_node.right == null)
                {
                    return true;
                }
                if (curr_node.right != null)
                {
                    s_node.Push(curr_node.right);
                    s_sum.Push(curr_sum + curr_node.right.val);
                }
                if (curr_node.left != null)
                {
                    s_node.Push(curr_node.left);
                    s_sum.Push(curr_sum + curr_node.left.val);
                }
            }
            return false;
        }

        // Recursive solution
        // Time complexity: O(n)
        // Space complexity: O(n))
        public static bool HasPathSum_2(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            if (root.left == null && root.right == null & targetSum - root.val == 0) return true;
            return HasPathSum_2(root.left, targetSum - root.val) || HasPathSum_2(root.right, targetSum - root.val);
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Path Sum_1-----");
            TreeNode t1_1 = new TreeNode(1);
            t1_1.left = new TreeNode(2);
            t1_1.right = new TreeNode(3);
            Console.WriteLine(HasPathSum_1(t1_1, 5));

            TreeNode t1_2 = new TreeNode(5);
            t1_2.left = new TreeNode(4);
            t1_2.right = new TreeNode(8);
            t1_2.left.left = new TreeNode(11);
            t1_2.right.left = new TreeNode(13);
            t1_2.right.right = new TreeNode(4);
            t1_2.left.left.left = new TreeNode(7);
            t1_2.left.left.right = new TreeNode(2);
            t1_2.right.right.right = new TreeNode(1);
            Console.WriteLine(HasPathSum_1(t1_2, 22));

            TreeNode t1_3 = new TreeNode();
            Console.WriteLine(HasPathSum_1(t1_3, 5));

            TreeNode t1_4 = new TreeNode(1);
            t1_4.left = new TreeNode(2);
            Console.WriteLine(HasPathSum_1(t1_4, 0));

            Console.WriteLine("-----Path Sum_2-----");
            TreeNode t2_1 = new TreeNode(1);
            t2_1.left = new TreeNode(2);
            t2_1.right = new TreeNode(3);
            Console.WriteLine(HasPathSum_2(t2_1, 5));

            TreeNode t2_2 = new TreeNode(5);
            t2_2.left = new TreeNode(4);
            t2_2.right = new TreeNode(8);
            t2_2.left.left = new TreeNode(11);
            t2_2.right.left = new TreeNode(13);
            t2_2.right.right = new TreeNode(4);
            t2_2.left.left.left = new TreeNode(7);
            t2_2.left.left.right = new TreeNode(2);
            t2_2.right.right.right = new TreeNode(1);
            Console.WriteLine(HasPathSum_1(t2_2, 22));

            TreeNode t2_3 = new TreeNode();
            Console.WriteLine(HasPathSum_1(t2_3, 5));

            TreeNode t2_4 = new TreeNode(1);
            t2_4.left = new TreeNode(2);
            Console.WriteLine(HasPathSum_1(t2_4, 0));
        }
    }
}