func characterReplacement(s string, k int) int {
	counts := make(map[byte]int) // Using a map to track character frequencies
	left, longest, maxFreq := 0, 0, 0
	for right := 0; right < len(s); right++ {
		char := s[right]
		counts[char]++
		maxFreq = max(maxFreq, counts[char]) // only care about the max freq, the rest will just be total count - max freq
		for (right-left+1)-maxFreq > k { // Shrink window if replacements exceed k
			counts[s[left]]--
			left++
		}
		longest = max(longest, right-left+1)
	}
	return longest
}
