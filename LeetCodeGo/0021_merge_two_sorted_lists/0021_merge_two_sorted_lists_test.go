package merge_two_sorted_lists

import (
	"reflect"
	"testing"
)

func TestMergeTwoLists(t *testing.T) {
	tests := []struct {
		name     string
		l1       []int
		l2       []int
		expected []int
	}{
		{
			name:     "No 1: Normal Case",
			l1:       []int{1, 2, 4},
			l2:       []int{1, 3, 4},
			expected: []int{1, 1, 2, 3, 4, 4},
		},
		{
			name:     "No 2: two empty list merge",
			l1:       []int{},
			l2:       []int{},
			expected: []int{},
		},
		{
			name:     "No 3: one empty list merge",
			l1:       []int{},
			l2:       []int{0},
			expected: []int{0},
		},
		{
			name:     "No 4: Different length",
			l1:       []int{2},
			l2:       []int{1, 3, 5, 7},
			expected: []int{1, 2, 3, 5, 7},
		},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			list1 := sliceToList(tc.l1)
			list2 := sliceToList(tc.l2)

			mergedHead := MergeTwoLists(list1, list2)

			result := listToSlice(mergedHead)

			if !reflect.DeepEqual(result, tc.expected) {
				t.Errorf("Case [%s] Failed！ Expect: %v, Actual: %v", tc.name, tc.expected, result)
			}
		})
	}
}

// --- Helper Functions  ---

func sliceToList(nums []int) *ListNode {
	if len(nums) == 0 {
		return nil
	}
	dummy := &ListNode{}
	curr := dummy
	for _, val := range nums {
		curr.Next = &ListNode{Val: val}
		curr = curr.Next
	}
	return dummy.Next
}

func listToSlice(head *ListNode) []int {
	nums := []int{}
	for head != nil {
		nums = append(nums, head.Val)
		head = head.Next
	}
	return nums
}
