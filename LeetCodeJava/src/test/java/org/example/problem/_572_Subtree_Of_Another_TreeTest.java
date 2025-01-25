package org.example.problem;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

class _572_Subtree_Of_Another_TreeTest {
    _572_Subtree_Of_Another_Tree isSubtreeSolver = new _572_Subtree_Of_Another_Tree();
    public class TreeNode extends _572_Subtree_Of_Another_Tree.TreeNode {
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

    @Test
    void isSubtree_1() {
        // Test case 1:

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

        boolean expected1 = true;
        boolean result1 = isSubtreeSolver.isSubtree_1(root_case1, subRoot_case1);
        System.out.println("result: " + result1 + ", Expected: " + expected1);
        assertEquals(expected1, result1, "Expected: " + expected1 + ", Actual: " + result1);

        // Test case 2:
        // root
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

        boolean expected2 = true;
        boolean result2 = isSubtreeSolver.isSubtree_1(root_case2, subRoot_case2);
        System.out.println("result: " + result2 + ", Expected: " + expected2);
        assertEquals(expected2, result2, "Expected: " + expected2 + ", Actual: " + result2);
    }
}