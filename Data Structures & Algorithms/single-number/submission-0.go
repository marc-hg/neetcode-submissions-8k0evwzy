func singleNumber(nums []int) int {
	uniqueNumbers := map[int]bool{}
	for _, value := range nums {
		if uniqueNumbers[value] {
			delete(uniqueNumbers, value)
		} else {
			uniqueNumbers[value] = true
		}
	}
	for key, _:= range uniqueNumbers{
		return key
	}
	return -1

}
