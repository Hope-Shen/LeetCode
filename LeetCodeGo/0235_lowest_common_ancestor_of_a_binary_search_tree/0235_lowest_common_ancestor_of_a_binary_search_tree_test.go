package lowest_common_ancestor_of_a_binary_search_tree

import (
	"LeetCode/LeetCodeGo/utility"
	"testing"
)

// Helper function to find a node with a specific value in a BST.
// This is needed because the test input gives values, but the function expects *TreeNode pointers.
func findNode(root *utility.TreeNode, val int) *utility.TreeNode {
	if root == nil || root.Val == val {
		return root
	}
	if val < root.Val {
		return findNode(root.Left, val)
	}
	return findNode(root.Right, val)
}

func TestLowestCommonAncestor(t *testing.T) {
	tests := []struct {
		name     string
		root     []int
		pVal     int
		qVal     int
		expected int
	}{
		{
			name:     "Example 1 - LCA is Root",
			root:     []int{6, 2, 8, 0, 4, 7, 9, utility.NULL, utility.NULL, 3, 5},
			pVal:     2,
			qVal:     8,
			expected: 6,
		},
		{
			name:     "Example 2 - LCA is Parent of One Node",
			root:     []int{6, 2, 8, 0, 4, 7, 9, utility.NULL, utility.NULL, 3, 5},
			pVal:     2,
			qVal:     4,
			expected: 2,
		},
		{
			name:     "Example 3 - Small Tree",
			root:     []int{2, 1},
			pVal:     2,
			qVal:     1,
			expected: 2,
		},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			root := utility.IntsToTree(tc.root)

			pNode := findNode(root, tc.pVal)
			qNode := findNode(root, tc.qVal)

			result := lowestCommonAncestor(root, pNode, qNode)

			if result == nil || result.Val != tc.expected {
				var resVal int
				if result != nil {
					resVal = result.Val
				} else {
					resVal = -1
				}

				t.Errorf("Case [%s] Failed! Expect: %v, Actual: %v", tc.name, tc.expected, resVal)
			}
		})
	}
}
