using System;

namespace LeetCodeCSharp_Insert_Into_Binary_Search_Tree
{
    /*
    701_Insert_Into_Binary_Search_Tree
    2021/08/15

    You are given the root node of a binary search tree (BST) and a value to insert into the tree. 
    Return the root node of the BST after the insertion. It is guaranteed that the new value does not exist in the original BST.

    Notice that there may exist multiple valid ways for the insertion, 
    as long as the tree remains a BST after insertion. You can return any of them.

    Example 1:
    Input: root = [4,2,7,1,3], val = 5
    Output: [4,2,7,1,3,5]
    Explanation: Another accepted tree is:
    
    Example 2:
    Input: root = [40,20,60,10,30,50,70], val = 25
    Output: [40,20,60,10,30,50,70,null,null,25]
    
    Example 3:
    Input: root = [4,2,7,1,3,null,null,null,null,null,null], val = 5
    Output: [4,2,7,1,3,5]
    */

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
    public class Insert_Into_Binary_Search_Tree
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return new TreeNode(val, null, null);
            }
            //go right
            if (root.val < val)
            {
                if (root.right == null)
                {
                    root.right = new TreeNode(val, null, null);
                }
                else
                {
                    InsertIntoBST(root.right, val);
                }
            }
            //go left
            else
            {
                if (root.left == null)
                {
                    root.left = new TreeNode(val, null, null);
                }
                else
                {
                    InsertIntoBST(root.left, val);
                }
            }

            return root;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Insert Into Binary Search Tree-----");
            TreeNode t1 = new TreeNode(4);
            t1.left = new TreeNode(2);
            t1.right = new TreeNode(7);
            t1.left.left = new TreeNode(1);
            t1.left.right = new TreeNode(3);
            Console.WriteLine(string.Join(", ", InsertIntoBST(t1, 5)));

            TreeNode t2 = new TreeNode(40);
            t2.left = new TreeNode(20);
            t2.right = new TreeNode(60);
            t2.left.left = new TreeNode(10);
            t2.left.right = new TreeNode(30);
            t2.right.left = new TreeNode(50);
            t2.right.right = new TreeNode(70);
            Console.WriteLine(string.Join(", ", InsertIntoBST(t2, 5)));
            
            TreeNode t3 = new TreeNode();
            Console.WriteLine(string.Join(", ", InsertIntoBST(t3, 5)));
        }
    }
}