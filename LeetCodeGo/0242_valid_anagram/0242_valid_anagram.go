package valid_anagram

// Time complexity: O(n)
// Space complexity: O(1)
func IsAnagram(s string, t string) bool {
	// Check lenght, if len(s) != len(t) the false
	if len(s) != len(t) {
		return false
	}

	var charCount [26]int // so Space complexity = O(1)

	for i := 0; i < len(s); i++ { // -> O(n)
		charCount[s[i]-'a']++
		charCount[t[i]-'a']--
	}

	for _, count := range charCount { //O(n)
		if count != 0 {
			return false
		}
	}
	return true
}

// s = "cab", t = "acb"
// i=0：
// charCount['c'] ++ -> [0, 0, 1]
// charCount['a'] -- -> [-1, 0, 1]

// i=1：
// charCount['a'] ++ -> [0, 0, 1]
// charCount['a'] -- -> [0, 0, 0]

// i=2：
// charCount['t'] ++ -> [0, 1, 0]
// charCount['t'] -- -> [0, 0, 0]
// Final -> [0, 0, 0]

// if 最後都是0 代表示is anagram

// Using Map
// Time complexity: O(n)
// Space complexity: O(n)
func IsAnagramMap(s string, t string) bool {
	rs := []rune(s) // Type Conversion -> string value split to Slice
	rt := []rune(t)

	if len(s) != len(t) {
		return false
	}

	// create Map
	counts := make(map[rune]int)

	for _, c := range rs {
		counts[c]++
	}

	for _, c := range rt {
		counts[c]--

		// 如果減完為負數 則代表 t 的字數比 s 多 那就不是Anagram
		if counts[c] < 0 {
			return false
		}
	}

	return true
}
