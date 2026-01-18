package best_time_buy_sell_stock

// Time complexity: O(n)
// Space complexity: O(1)
func maxProfit(prices []int) int {
	maxProfit := 0

	left := 0  // keep the min
	right := 1 // go through each element

	for right < len(prices) {
		if prices[left] < prices[right] {
			profit := prices[right] - prices[left]
			maxProfit = max(maxProfit, profit)
		} else {
			left = right
		}
		right++
	}

	return maxProfit

}
