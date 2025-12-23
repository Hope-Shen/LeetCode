package contains_duplicate

// Time complexity: O(n)
// Space complexity: O(n)
func ContainsDuplicate(nums []int) bool {
	//hashSet
	//最後的len 是給map 初始容量，避免map 一直擴充
	seen := make(map[int]bool, len(nums))

	for _, num := range nums { // O(n)
		if seen[num] == true { // Map -> O(1)
			return true
		}
		seen[num] = true // Map -> O(1)
	}

	return false
}
