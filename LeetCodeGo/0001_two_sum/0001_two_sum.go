package two_sum

// Time complexity: O(n)
// Space complexity: O(n)
func twoSum(nums []int, target int) []int {
	seen := make(map[int]int)

	// i = index, num = value
	for i, num := range nums { // O(n)
		partner := target - num

		if idx, ok := seen[partner]; ok { // Map -> O(1)
			return []int{idx, i}
		}
		seen[num] = i // Map -> O(1)
	}
	return nil
}
