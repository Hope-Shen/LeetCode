using System;

namespace LeetCodeCSharp_Symmetric_Tree
{
    /*
    101_Symmetric_Tree
    2021/08/15

    Given the root of a binary tree, check whether it is a mirror of itself 
    (i.e., symmetric around its center).

    Example 1:
    Input: root = [1,2,2,3,4,4,3]
    Output: true
    
    Example 2:
    Input: root = [1,2,2,null,3,null,3]
    Output: false
    */
    public class Symmetric_Tree
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

        // Recursive
        // Time complexity: O(n)
        // Space complexity: O(n)
        public static bool IsSymmetric(TreeNode root)
        {
            if(root == null) return true;
            return IsMirror(root, root);
        }

        public static bool IsMirror(TreeNode left_root, TreeNode right_root)
        {
            if (left_root == null && right_root == null) return true;
            if(left_root == null || right_root == null) return false;
            if(left_root.val != right_root.val) return false;
            return IsMirror(left_root.left, right_root.right) && IsMirror(left_root.right, right_root.left);
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Symmetric Tree-----");
            TreeNode t1 = new TreeNode(1);
            t1.left = new TreeNode(2);
            t1.right = new TreeNode(2);
            t1.left.left = new TreeNode(3);
            t1.left.right = new TreeNode(4);
            t1.right.left = new TreeNode(4);
            t1.right.right = new TreeNode(3);
            Console.WriteLine(IsSymmetric(t1));
            
            TreeNode t2 = new TreeNode(1);
            t2.left = new TreeNode(2);
            t2.right = new TreeNode(2);
            t2.left.left = new TreeNode(3);
            t2.right.right = new TreeNode(3);
            Console.WriteLine(IsSymmetric(t2));
            
            TreeNode t3 = new TreeNode(1);
            t3.left = new TreeNode(2);
            t3.right = new TreeNode(2);
            t3.left.right = new TreeNode(3);
            t3.right.right = new TreeNode(3);
            Console.WriteLine(IsSymmetric(t3));

            TreeNode t4 = new TreeNode(1);
            t4.left = new TreeNode(2);
            t4.right = new TreeNode(2);
            t4.left.left = new TreeNode(4);
            t4.left.right = new TreeNode(3);
            t4.right.right = new TreeNode(3);
            Console.WriteLine(IsSymmetric(t4));
        }
    }
}