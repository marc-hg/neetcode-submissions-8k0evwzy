import "slices"

func trap(height []int) int {
	totalWater := 0
	for i, _ := range height {
		area := colArea(i, height)
		totalWater += area
	}
	return totalWater
}

func colArea(i int, nums []int) int {
	if i == 0 || i == len(nums)-1 {
		return 0
	}

	leftLargest := slices.Max(nums[:i])
	rightLargest := slices.Max(nums[i+1:])

	return max(min(leftLargest, rightLargest)-nums[i], 0)
}
