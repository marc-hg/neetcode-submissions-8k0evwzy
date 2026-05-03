func maxProfit(prices []int) int {
	left, maxProfit := 0, 0
	for right := 0; right < len(prices); right++ {
		// If the current price is lower than our buy price,
		// slide the left pointer to the new minimum.
		if prices[right] < prices[left] {
			left = right
		}
		currentProfit := prices[right] - prices[left]
		maxProfit = max(maxProfit, currentProfit)
	}
	return max(0, maxProfit)

}

