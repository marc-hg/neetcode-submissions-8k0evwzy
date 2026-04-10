func evalRPN(tokens []string) int {
	var stack []int
	for _, v := range tokens {
		if isOperator(v) {
			n := len(stack)
			if n < 1 {
				panic("bad tokens")
			}
			operator := v
			y := stack[n-1]
			x := stack[n-2]
			stack = stack[:n-2]
			var result int
			if operator == "+" {
				result = x + y
			} else if operator == "-" {
				result = x - y
			} else if operator == "*" {
				result = x * y
			} else if operator == "/" {
				result = x / y
			} else {
				panic("unsupported operator")
			}
			stack = append(stack, result)
		} else {
			number, err := strconv.Atoi(v)
			if err != nil {
				panic("non number on token")
			}
			stack = append(stack, number)
		}
	}

	return stack[0]

}

func isOperator(symbol string) bool {
	possibleOperators := map[string]bool{"+": true, "-": true, "*": true, "/": true}
	return possibleOperators[symbol]
}
