package reverse_string

import (
	"bytes" // 用來比較 []byte 非常好用
	"testing"
)

func TestReverseString(t *testing.T) {
	tests := []struct {
		name     string
		input    []byte // 輸入
		expected []byte // 預期變成的樣子
	}{
		{
			name:     "No 1: hello",
			input:    []byte{'h', 'e', 'l', 'l', 'o'},
			expected: []byte{'o', 'l', 'l', 'e', 'h'},
		},
		{
			name:     "No 2: Hannah",
			input:    []byte{'H', 'a', 'n', 'n', 'a', 'h'},
			expected: []byte{'h', 'a', 'n', 'n', 'a', 'H'},
		},
		{
			name:     "No 3: one letter",
			input:    []byte{'A'},
			expected: []byte{'A'},
		},
		{
			name:     "No 4: empty string",
			input:    []byte{},
			expected: []byte{},
		},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			// 為了不影響下一次測試 (雖然這裡是 table-driven 每次都是新的 slice，但好習慣是 copy 一份)
			// 在這裡我們直接傳入 tc.input 即可，因為 struct 裡的 slice 也是參照
			// 但為了安全起見，我們複製一份來測，避免改到原始 test case 資料
			nums := make([]byte, len(tc.input))
			copy(nums, tc.input)

			// 執行原地反轉
			reverseString(nums)

			// 檢查結果：使用 bytes.Equal 來比較兩個 []byte 是否相等
			if !bytes.Equal(nums, tc.expected) {
				t.Errorf("Case [%s] Failed！ Expect: %v, Actual: %v", tc.name, tc.expected, nums)
			}
		})
	}
}
