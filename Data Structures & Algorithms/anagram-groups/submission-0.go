func groupAnagrams(strs []string) [][]string {
	anagramHashes := map[[26]int][]string{}
	for _, value := range strs {
		anagramHash := CalculateAnagramHash(value)

		anagramHashes[anagramHash] = append(anagramHashes[anagramHash], value)
	}

	result := [][]string{}
	for _, group := range anagramHashes {
		result = append(result, group)
	}

	return result
}

func CalculateAnagramHash(value string) [26]int{
	var count [26]int
	for _,r :=range value{
		count [r - 'a']++
	}
	return count
}
