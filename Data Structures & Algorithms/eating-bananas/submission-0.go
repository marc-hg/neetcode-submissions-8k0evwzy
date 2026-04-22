import "slices"

func minEatingSpeed(piles []int, h int) int {
	maxK := slices.Max(piles) // O(n)

	low := 1
	high := maxK

	lowestK := -1
	for low <= high {
		mid := low + (high-low)/2
		kTime := calculateKTime(piles, mid)

		// burst, need to go to eat more bananas (k)
		if kTime > h {
			low = mid + 1
		} else {
			// If it didn't burst, record the time and keep trying until burst
			lowestK = mid
			high = mid - 1
		}

	}
	return lowestK
}

func calculateKTime(piles []int, k int) int {
	time := 0
	for _, v := range piles {
		if k == 0 {
			continue
		}
		time += (k + v - 1) / k
	}
	return time
}
