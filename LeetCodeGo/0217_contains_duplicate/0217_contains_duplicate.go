package contains_duplicate

import "sort"

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

// Time complexity: O(n log n))
// Space complexity: O(log n)
func ContainsDuplicateSort(nums []int) bool {
	sort.Ints(nums)
	for i := 1; i < len(nums); i++ {
		if nums[i] == nums[i-1] {
			return true
		}
	}
	return false
}
