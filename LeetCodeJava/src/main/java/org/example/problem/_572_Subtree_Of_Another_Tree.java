package org.example.problem;

import java.util.Arrays;
import java.util.HashSet;


public class _572_Subtree_Of_Another_Tree {
    /*
    Date: 2025-01-08
    572_Subtree_Of_Another_Tree

    Given the roots of two binary trees root and subRoot,
    return true if there is a subtree of root with the same structure and node values of subRoot and false otherwise.
    A subtree of a binary tree is a tree that consists of a node in tree and all of this node's descendants.
    The tree could also be considered as a subtree of itself.

    Example 1:
    Input: root = [3,4,5,1,2], subRoot = [4,1,2]
    Output: true
            root        subRoot
            3               4
          /  \             / \
         4    5           1   2
        / \
       1   2

    Example 2:
    Input: root = [3,4,5,1,2,null,null,null,null,0], subRoot = [4,1,2]
    Output: false


    Constraints:
    The number of nodes in the root tree is in the range [1, 2000].
    The number of nodes in the subRoot tree is in the range [1, 1000].
    -104 <= root.val <= 104
    -104 <= subRoot.val <= 104
    */
    public void subtreeOfAnotherTree(){
        System.out.println("##### 572_Subtree_Of_Another_Tree #####");

        // test case 1
        // root
        TreeNode rootNode3_left_case1 = new TreeNode(1);
        TreeNode rootNode3_right_case1 = new TreeNode(2);
        TreeNode rootNode2_lefr_case1 = new TreeNode(4, rootNode3_left_case1, rootNode3_right_case1);
        TreeNode rootNode2_right_case1 = new TreeNode(5);
        TreeNode root_case1 = new TreeNode(3, rootNode2_lefr_case1, rootNode2_right_case1);

        // subRoot
        TreeNode subRootNode2_left_case1 = new TreeNode(1);
        TreeNode subRootNode2_right_case1 = new TreeNode(2);
        TreeNode subRoot_case1 = new TreeNode(4, subRootNode2_left_case1, subRootNode2_right_case1);

        // test case 2
        TreeNode rootNode4_left_case2 = new TreeNode(0);
        TreeNode rootNode3_left_case2 = new TreeNode(1);
        TreeNode rootNode3_right_case2 = new TreeNode(2, rootNode4_left_case2, null);
        TreeNode rootNode2_left_case2 = new TreeNode(4, rootNode3_left_case2, rootNode3_right_case2);
        TreeNode rootNode2_right_case2 = new TreeNode(5);
        TreeNode root_case2 = new TreeNode(3, rootNode2_left_case2, rootNode2_right_case2);

        // subRoot
        TreeNode subRootNode2_left_case2 = new TreeNode(1);
        TreeNode subRootNode2_right_case2 = new TreeNode(2);
        TreeNode subRoot_case2 = new TreeNode(4, subRootNode2_left_case2, subRootNode2_right_case2);

        // solution 1
        System.out.println("solution 1");

        boolean result = isSubtree_1(root_case1, subRoot_case1);
        System.out.println("True - " + result);

        result = isSubtree_1(root_case2, subRoot_case2);
        System.out.println("False - " + result);
    }

    //    Definition for a binary tree node.
    public static class TreeNode {
        int val;
        TreeNode left;
        TreeNode right;
        TreeNode() {}
        TreeNode(int val) { this.val = val; }
        TreeNode(int val, TreeNode left, TreeNode right) {
          this.val = val;
          this.left = left;
          this.right = right;
        }
    }

    protected boolean isSubtree_1(TreeNode root, TreeNode subRoot) {
        // Time complexity: O(n * m)
        // Space complexity: O(n + m)

        if (root == null) {
            return false; // An empty tree cannot contain any subtree.
        }
        if (isSameTree(root, subRoot)) {
            return true; // current root equal subRoot
        }
        // Recursively check the left subtree or the right subtree.
        return isSubtree_1(root.left, subRoot) || isSubtree_1(root.right, subRoot);
    }

    private boolean isSameTree(TreeNode s, TreeNode t) {
        if (s == null && t == null) {
            return true; // both tree == null ->  is same tree
        }
        if (s == null || t == null) {
            return false; // on tree is null and the other is not -> not same tree
        }
        if (s.val != t.val) {
            return false; // leaf not equal -> not same tree
        }
        // Recursively check the left subtree or the right subtree.
        return isSameTree(s.left, t.left) && isSameTree(s.right, t.right);
    }
}
