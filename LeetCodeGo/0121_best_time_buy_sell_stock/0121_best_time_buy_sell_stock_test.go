package best_time_buy_sell_stock

import (
	"testing"
)

func TestMaxProfit(t *testing.T) {
	tests := []struct {
		name     string
		prices   []int
		expected int
	}{
		{
			name:     "No 1: Nomal Case",
			prices:   []int{7, 1, 5, 3, 6, 4},
			expected: 5,
		},
		{
			name:     "No 2: On Profit",
			prices:   []int{7, 6, 4, 3, 1},
			expected: 0,
		},
		{
			name:     "No 3: empty slice",
			prices:   []int{},
			expected: 0,
		},
		{
			name:     "No 4: only one price",
			prices:   []int{5},
			expected: 0,
		},
		{
			name:     "No 5",
			prices:   []int{2, 4, 1},
			expected: 2,
		},
		{
			name:     "No 6",
			prices:   []int{1, 20, 1, 100},
			expected: 99,
		},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			result := maxProfit(tc.prices)

			if result != tc.expected {
				t.Errorf("Case [%s] Failed！ Expect: %v, Actual: %v", tc.name, tc.expected, result)
			}
		})
	}
}
