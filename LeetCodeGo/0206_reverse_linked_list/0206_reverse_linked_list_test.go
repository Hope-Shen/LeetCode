package reverse_linked_list

import (
	"reflect"
	"testing"
)

// 測試主程式
func TestReverseList(t *testing.T) {
	tests := []struct {
		name     string
		input    []int
		expected []int
	}{
		{
			name:     "No 1: 1->2->3->4->5",
			input:    []int{1, 2, 3, 4, 5},
			expected: []int{5, 4, 3, 2, 1},
		},
		{
			name:     "No 2: 1->2",
			input:    []int{1, 2},
			expected: []int{2, 1},
		},
		{
			name:     "No 3: 空鏈表",
			input:    []int{},
			expected: []int{},
		},
		{
			name:     "No 4: 只有一個節點",
			input:    []int{1},
			expected: []int{1},
		},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			head := sliceToList(tc.input)

			newHead := reverseList(head)

			result := listToSlice(newHead)

			if !reflect.DeepEqual(result, tc.expected) {
				t.Errorf("Case [%s] Failed！ Expect: %v, Actual: %v", tc.name, tc.expected, result)
			}
		})
	}
}

// --- Helpers Function ---

func sliceToList(nums []int) *ListNode {
	if len(nums) == 0 {
		return nil
	}
	head := &ListNode{Val: nums[0]}
	curr := head
	for i := 1; i < len(nums); i++ {
		curr.Next = &ListNode{Val: nums[i]}
		curr = curr.Next
	}
	return head
}

func listToSlice(head *ListNode) []int {
	nums := []int{}
	curr := head
	for curr != nil {
		nums = append(nums, curr.Val)
		curr = curr.Next
	}
	return nums
}
