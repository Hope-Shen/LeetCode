package utility

// TreeNode represents a node in a binary tree
type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

// --- Helper Functions ---

// IntsToTree converts an array of integers to a binary tree using level-order traversal
func IntsToTree(nums []int) *TreeNode {
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

// TreeToInts converts a binary tree to an array of integers using level-order traversal
func TreeToInts(root *TreeNode) []int {
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