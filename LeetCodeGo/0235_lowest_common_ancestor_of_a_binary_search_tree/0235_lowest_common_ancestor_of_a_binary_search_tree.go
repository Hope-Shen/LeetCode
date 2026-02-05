package lowest_common_ancestor_of_a_binary_search_tree

import "LeetCode/LeetCodeGo/utility"

// Time complexity: O(h) where h is the height of the tree.
// Space complexity: O(1)
func lowestCommonAncestor(root, p, q *utility.TreeNode) *utility.TreeNode {
	current := root

	for current != nil {
		if current.Val > p.Val && current.Val > q.Val {
			current = current.Left
		} else if current.Val < p.Val && current.Val < q.Val {
			current = current.Right
		} else {
			// because we don't know which one is bigger
			// p <= current <= q
			// q <= current <= p
			// 另種可能 current 就是 p 或 q 本身
			return current
		}
	}
	return nil
}
