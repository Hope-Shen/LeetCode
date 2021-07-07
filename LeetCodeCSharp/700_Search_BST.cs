using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Search_BST
{
    /*
    700_Search_BST
    2021/07/06
    You are given the root of a binary search tree (BST) and an integer val.
    
    Find the node in the BST that the node's value equals val and return the subtree rooted with that node. 
    If such a node does not exist, return null.

    Example 1:
    Input: root = [4,2,7,1,3], val = 2
    Output: [2,1,3]

    Example 2:
    Input: root = [4,2,7,1,3], val = 5
    Output: []
    
    Constraints:
    The number of nodes in the tree is in the range [1, 5000].
    1 <= Node.val <= 107
    root is a binary search tree.
    1 <= val <= 107
    */

    // Definition for a binary tree node.
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Search_BST
    {
        public static TreeNode SearchBST(TreeNode root, int val) 
        {
            if (root == null) 
            {
                return null;
            }

            if (root.val == val)
            {
                return root;
            }
            else if (root.val > val)
            {
                return SearchBST(root.left, val);
            }
            else
            {
                return SearchBST(root.right, val);
            }
            /*Short hand
                if ( root == null) return null;
                if ( root.val == val) return root;
                else if ( root.val > val ) return SearchBST(root.left, val);
                else return SearchBST(root.right, val);
            */
            
        }
        
        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            
            TreeNode t1 = new TreeNode(4);
            t1.left = new TreeNode(2);
            t1.right = new TreeNode(7);
            t1.left.left = new TreeNode(1);
            t1.left.right = new TreeNode(3);
            
            Console.WriteLine("-----SearchBST-----");
            TreeNode resultList_1 = SearchBST(t1, 2);
            Console.WriteLine(resultList_1.val);

            TreeNode resultList_2 = SearchBST(t1, 5);
            Console.WriteLine(resultList_2.val);
        }
    }
}