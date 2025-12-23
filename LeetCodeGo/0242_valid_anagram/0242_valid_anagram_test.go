package valid_anagram

import "testing"

func TestIsAnagram(t *testing.T) {
	tests := []struct {
		name     string
		s        string
		t        string
		expected bool
	}{
		{
			name:     "No 1: Is Anagram",
			s:        "anagram",
			t:        "nagaram",
			expected: true,
		},
		{
			name:     "No 2: Not Anagram",
			s:        "rat",
			t:        "car",
			expected: false,
		},
		{
			name:     "No 3: Different Length",
			s:        "a",
			t:        "ab",
			expected: false,
		},
		{
			name:     "No 4: Empty String",
			s:        "",
			t:        "",
			expected: true,
		},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			result := IsAnagram(tc.s, tc.t)
			if result != tc.expected {
				t.Errorf("Case [%s] Failed！ Expect: %v, Actual: %v", tc.name, tc.expected, result)
			}
		})
	}
}
