package invert_binary_tree

import (
	"reflect"
	"testing"
)

func TestInvertTree(t *testing.T) {
	tests := []struct {
		name     string
		root     []int
		expected []int
	}{
		{
			name:     "No 1: Basic Tree [2,1,3]",
			root:     []int{2, 1, 3},
			expected: []int{2, 3, 1},
		},
		{
			name:     "No 2: Full Tree [4,2,7,1,3,6,9]",
			root:     []int{4, 2, 7, 1, 3, 6, 9},
			expected: []int{4, 7, 2, 9, 6, 3, 1},
		},
		{
			name:     "No 3: Empty Tree",
			root:     []int{},
			expected: []int{},
		},
		{
			name:     "No 4: Single Node",
			root:     []int{1},
			expected: []int{1},
		},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			// 1. Setup: 將 []int 轉為 *TreeNode
			inputTree := intsToTree(tc.root)

			// 2. Execute: 執行翻轉
			resultTree := invertTree(inputTree)

			// 3. Transform Back: 將結果轉回 []int 以便驗證
			resultSlice := treeToInts(resultTree)

			// 4. Assertion: 比對 []int 是否一致
			if !reflect.DeepEqual(resultSlice, tc.expected) {
				t.Errorf("Case [%s] Failed! Expect: %v, Actual: %v", tc.name, tc.expected, resultSlice)
			}
		})
	}
}

// --- Helper Functions ---
func intsToTree(nums []int) *TreeNode {
	if len(nums) == 0 {
		return nil
	}

	root := &TreeNode{Val: nums[0]}
	queue := []*TreeNode{root}
	i := 1

	for i < len(nums) {
		curr := queue[0]
		queue = queue[1:]

		// add left node
		if i < len(nums) {
			curr.Left = &TreeNode{Val: nums[i]}
			queue = append(queue, curr.Left)
			i++
		}
		// add right node
		if i < len(nums) {
			curr.Right = &TreeNode{Val: nums[i]}
			queue = append(queue, curr.Right)
			i++
		}
	}
	return root
}

func treeToInts(root *TreeNode) []int {
	if root == nil {
		return []int{}
	}

	result := []int{}
	queue := []*TreeNode{root}

	for len(queue) > 0 {
		curr := queue[0]
		queue = queue[1:]

		result = append(result, curr.Val)

		if curr.Left != nil {
			queue = append(queue, curr.Left)
		}
		if curr.Right != nil {
			queue = append(queue, curr.Right)
		}
	}
	return result
}
