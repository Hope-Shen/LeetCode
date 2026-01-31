package binary_search

import (
	"reflect"
	"testing"
)

func TestSearch(t *testing.T) {
	tests := []struct {
		name     string
		nums     []int
		target   int
		expected int
	}{
		{
			name:     "Example 1 - Target Exists",
			nums:     []int{-1, 0, 3, 5, 9, 12},
			target:   9,
			expected: 4,
		},
		{
			name:     "Example 2 - Target Does Not Exist",
			nums:     []int{-1, 0, 3, 5, 9, 12},
			target:   2,
			expected: -1,
		},
		{
			name:     "Single Element - Found",
			nums:     []int{5},
			target:   5,
			expected: 0,
		},
		{
			name:     "Single Element - Not Found",
			nums:     []int{5},
			target:   0,
			expected: -1,
		},
		{
			name:     "Boundaries - First Element",
			nums:     []int{1, 2, 3},
			target:   1,
			expected: 0,
		},
		{
			name:     "Boundaries - Last Element",
			nums:     []int{1, 2, 3},
			target:   3,
			expected: 2,
		},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			result := search(tc.nums, tc.target)

			if !reflect.DeepEqual(result, tc.expected) {
				t.Errorf("Case [%s] Failed! Expect: %v, Actual: %v", tc.name, tc.expected, result)
			}
		})
	}
}
