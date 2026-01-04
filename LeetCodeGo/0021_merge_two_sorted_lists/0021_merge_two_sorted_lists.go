package merge_two_sorted_lists

type ListNode struct {
	Val  int
	Next *ListNode
}

// Time complexity: O(n)
// Space complexity: O(1) -> reuse list1 and list2
func MergeTwoLists(list1 *ListNode, list2 *ListNode) *ListNode {
	// Go 的 &ListNode{} default Val=0, Next=nil
	dummy := &ListNode{}

	curr := dummy

	for list1 != nil && list2 != nil {
		if list1.Val < list2.Val {
			curr.Next = list1
			list1 = list1.Next
		} else {
			curr.Next = list2
			list2 = list2.Next
		}
		curr = curr.Next // move to the end of the List
	}

	if list1 != nil {
		curr.Next = list1
	} else {
		curr.Next = list2
	}

	return dummy.Next
}
