func dailyTemperatures(temperatures []int) []int {
	results := make([]int, len(temperatures))
	for i, _ := range temperatures {
		results[i] = 0
		for j := i + 1; j < len(temperatures); j++ {
			if temperatures[j] > temperatures[i] {
				results[i] = j - i
				break
			}
		}
	}
	return results

}
