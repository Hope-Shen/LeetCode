package contains_duplicate

import "testing"

func TestContainsDuplicate(t *testing.T) {
	tests := []struct {
		name     string
		nums     []int
		expected bool
	}{
		{
			name:     "No 1: Dupliate [1,2,3,1]",
			nums:     []int{1, 2, 3, 1},
			expected: true,
		},
		{
			name:     "No 2: No Duplicate [1,2,3,4]",
			nums:     []int{1, 2, 3, 4},
			expected: false,
		},
		{
			name:     "No 3: Multiple Duplicates [1,1,1,3,3,4,3,2,4,2]",
			nums:     []int{1, 1, 1, 3, 3, 4, 3, 2, 4, 2},
			expected: true,
		},
		{
			name:     "No 3 Empty Slice",
			nums:     []int{},
			expected: false,
		},
		{
			name:     "No 4: one element",
			nums:     []int{100},
			expected: false,
		},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			result := ContainsDuplicate(tc.nums)
			if result != tc.expected {
				t.Errorf("Case [%s] Failed！ Expect: %v, Actual: %v", tc.name, tc.expected, result)
			}
		})
	}
}
