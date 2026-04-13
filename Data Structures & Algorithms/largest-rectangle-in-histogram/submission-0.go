
func largestRectangleArea(heights []int) int {
	largestArea := 0
	for i := 0; i < len(heights); i++ {
		l := i
		for l >= 0 {
			if heights[l] < heights[i] {
				break
			}
			l--
		}
		r := i
		for r < len(heights) {
			if heights[r] < heights[i] {
				break
			}
			r++
		}
		area := (r - l - 1) * heights[i]
		largestArea = max(area, largestArea)
	}
	return largestArea
}
