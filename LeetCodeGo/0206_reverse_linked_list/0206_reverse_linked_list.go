package reverse_linked_list

type ListNode struct {
	Val  int
	Next *ListNode
}

// Time complexity: O(n)
// Space complexity: O(1) -> only pre, curr, tmp
func reverseList(head *ListNode) *ListNode {
	var pre *ListNode = nil
	curr := head

	for curr != nil {
		tmp := curr.Next
		curr.Next = pre
		pre = curr
		curr = tmp
	}

	return pre
}
