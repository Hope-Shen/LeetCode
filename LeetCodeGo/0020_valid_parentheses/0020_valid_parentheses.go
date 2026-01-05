package vaild_parentheses

func isValid(s string) bool {
	dic := map[rune]rune{
		')': '(',
		']': '[',
		'}': '{',
	}

	result := []rune{}

	for _, c := range s {
		if left, ok := dic[c]; ok {
			if len(result) == 0 || result[len(result)-1] != left {
				return false
			}
			result = result[:len(result)-1]
		} else {
			result = append(result, c)
		}
	}

	return len(result) == 0
}
