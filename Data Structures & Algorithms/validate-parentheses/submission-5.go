func isValid(s string) bool {
	var stack []int32
	matchingSymbols := map[int32]int32{
		'(': ')',
		'[': ']',
		'{': '}',
	}
	for _, c := range s {
		_, leftSymbol := matchingSymbols[c]
		if leftSymbol {
			stack = append(stack, c)
		} else {
			if len(stack) == 0 {
				return false
			}
			peek := stack[len(stack)-1]
			if matchingSymbols[peek] != c {
				return false
			}

			stack = stack[:len(stack)-1]
		}

	}
	return len(stack) == 0
}
