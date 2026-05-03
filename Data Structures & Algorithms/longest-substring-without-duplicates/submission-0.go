func lengthOfLongestSubstring(s string) int {
	seen := map[byte]int{}
	left, maxLength := 0, 0

	for right := 0; right < len(s); right++ {
		currentChar := s[right]
		if idx, ok := seen[currentChar]; ok {
			left = max(left, idx+1)
		}
		seen[currentChar] = right
		maxLength = max(maxLength, right-left+1)
	}

	return maxLength

}
