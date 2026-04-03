func topKFrequent(nums []int, k int) []int {
	frequentMap := make(map[int]int)

	for _, n := range nums {
		frequentMap[n]++
	}

	bucket := make([][]int, len(nums) + 1)

	for num, count := range(frequentMap){
		bucket[count] = append(bucket[count], num)
	}

	res := []int{}

	for i:= len(bucket) - 1; i>=0; i-- {
		if len(bucket[i]) > 0{
			res = append(res, bucket[i]...)
		}

		if(len(res)>=k) {
			break
		}
	}

	return res[:k]

}
