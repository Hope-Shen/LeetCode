package valid_palindrome

import "unicode"

// Time complexity: O(n)
// Space complexity: O(n)
func validPalindrome(s string) bool {

	// string conver to rune 切片，avoid byte issue (e.g chinese or emoji...)
	runes := []rune(s) // space complexity 宣告了儲存string 轉乘rune 的結果，長度為string 的長度，所以是O(n)

	// two pointer
	left := 0
	right := len(runes) - 1

	for left < right { // 即時他有兩層迴圈，但因為left 跟right 相交即停止，所以只會執行O(n)
		for left < right && !isAlphanumeric(runes[left]) {
			left++
			// continue
		}

		for left < right && !isAlphanumeric(runes[right]) {
			right--
			// continue
		}

		if unicode.ToLower(runes[left]) != unicode.ToLower(runes[right]) {
			return false
		}

		left++
		right--
	}

	return true
}

func isAlphanumeric(r rune) bool {
	return unicode.IsLetter(r) || unicode.IsDigit(r)
}
