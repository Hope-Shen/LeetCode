package binary_search

// Time Complexity: O(log n) - 每一步都將搜尋空間減半。
// Space Complexity: O(1) - 僅使用常數額外空間儲存指標。
func search(nums []int, target int) int {
	left, right := 0, len(nums)-1

	for left <= right {
		mid := left + (right-left)/2
		if nums[mid] < target {
			left = mid + 1
		} else if nums[mid] > target {
			right = mid - 1
		} else {
			return mid
		}
	}
	return -1
}
