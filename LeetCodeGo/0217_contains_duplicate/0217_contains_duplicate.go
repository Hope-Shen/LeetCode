package contains_duplicate

func ContainsDuplicate(nums []int) bool {
	//hashSet
	//最後的len 是給map 初始容量，避免map 一直擴充
	seen := make(map[int]bool, len(nums))

	for _, num := range nums {
		if seen[num] == true {
			return true
		}
		seen[num] = true
	}

	return false
}
