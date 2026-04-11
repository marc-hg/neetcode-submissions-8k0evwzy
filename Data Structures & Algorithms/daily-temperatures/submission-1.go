func dailyTemperatures(temperatures []int) []int {
	results := make([]int, len(temperatures))
	var stack []int
	top := func() int { return stack[len(stack)-1] }
	for i, vI := range temperatures {
		for len(stack) > 0 && temperatures[top()] < vI {
			results[top()] = i - top()
			stack = stack[:len(stack)-1]
		}
		stack = append(stack, i)
	}
	return results
}
