func searchMatrix(matrix [][]int, target int) bool {
	n := len(matrix) * 2
	flattened := make([]int,0, n)
	for _, row := range matrix {
		flattened = append(flattened, row...)
	}
	return search(flattened, target) != -1

}

func search(nums []int, target int) int {
	low := 0
	high := len(nums) - 1

	for low <= high {
		mid := low + (high-low)/2
		if target == nums[mid] {
			return mid
		}

		if target > nums[mid] {
			low = mid + 1
		} else {
			high = mid - 1
		}
	}
	return -1
}
