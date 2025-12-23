package valid_palindrome

import "testing"

func TestIsPalindrome(t *testing.T) {
	tests := []struct {
		name     string
		input    string
		expected bool
	}{
		{
			name:     "No1: IsPalindrome",
			input:    "A man, a plan, a canal: Panama",
			expected: true,
		},
		{
			name:     "No2: Not Palindrome",
			input:    "race a car",
			expected: false,
		},
		{
			name:     "No 3: empty string",
			input:    " ",
			expected: true,
		},
		{
			name:     "No 4: only non-alphanumeric characters",
			input:    ".,",
			expected: true,
		},
		{
			name:     "No 5: one character",
			input:    "a",
			expected: true,
		},
		{
			name:     "No 6: number palindrome",
			input:    "12321",
			expected: true,
		},
		{
			name:     "No 7: chinese palindrome",
			input:    "上海自來水來自海上",
			expected: true,
		},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			result := validPalindrome(tc.input)
			if result != tc.expected {
				t.Errorf("Case [%s] Failed！ Expect: %v, Actual: %v", tc.name, tc.expected, result)
			}
		})
	}
}
