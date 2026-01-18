package invert_binary_tree

/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */

// Time complexity: O(n)
// Space complexity: O(h) -> Height of the tree, normally is DFS
func invertTree(root *TreeNode) *TreeNode {
	// 1. 終止條件 (Base Case)
	if root == nil {
		return nil
	}
	// 2. 核心邏輯：Swap
	root.Right, root.Left = root.Left, root.Right

	// 3. 遞迴 (Recursion)
	invertTree(root.Left)
	invertTree(root.Right)

	return root
}

type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}
