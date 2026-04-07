func trap(height []int) int {
	left := 0
	right := len(height) - 1

	leftMax := height[left]
	rightMax := height[right]

	totalWater := 0

	for left < right {
		if leftMax < rightMax {
			left++
			leftMax = max(leftMax, height[left])
			totalWater += leftMax - height[left]
		} else {
			right--
			rightMax = max(rightMax, height[right])
			totalWater += rightMax - height[right]
		}
	}
	return totalWater
}
