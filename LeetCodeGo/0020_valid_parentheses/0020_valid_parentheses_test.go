package vaild_parentheses

import "testing"

func TestIsValid(t *testing.T) {
	tests := []struct {
		name     string
		input    string
		expected bool
	}{
		{
			name:     "No 1: simple pair",
			input:    "()",
			expected: true,
		},
		{
			name:     "No 2: muti pair",
			input:    "()[]{}",
			expected: true,
		},
		{
			name:     "No 3: unpair",
			input:    "(]",
			expected: false,
		},
		{
			name:     "No 4: unpair",
			input:    "([)]",
			expected: false,
		},
		{
			name:     "No 5: simple pair",
			input:    "{[]}",
			expected: true,
		},
		{
			name:     "No 6: edge case",
			input:    "[",
			expected: false,
		},
		{
			name:     "No 7: edge case",
			input:    "]",
			expected: false,
		},
		{
			name:     "No 8: complicated pair",
			input:    "(([]){})",
			expected: true,
		},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			result := isValid(tc.input)
			if result != tc.expected {
				t.Errorf("Case [%s] Failed！ Expect: %v, Actual: %v", tc.name, tc.expected, result)
			}
		})
	}
}
