package two_sum

func twoSum(nums []int, target int) []int {
	seen := make(map[int]int)

	// i = index, num = value
	for i, num := range nums {
		partner := target - num

		if idx, ok := seen[partner]; ok {
			return []int{idx, i}
		}
		seen[num] = i
	}
	return nil
}
