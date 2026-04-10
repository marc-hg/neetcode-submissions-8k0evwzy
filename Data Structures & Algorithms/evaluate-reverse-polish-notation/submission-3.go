func evalRPN(tokens []string) int {
	var numbersStack []int
	for _, v := range tokens {
		if isOperator(v) {
			if len(numbersStack) < 1 {
				panic("bad tokens")
			}
			operator := v
			y := numbersStack[len(numbersStack)-1]
			x := numbersStack[len(numbersStack)-2]
			numbersStack = numbersStack[:len(numbersStack)-2]
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
			numbersStack = append(numbersStack, result)
		} else {
			number, err := strconv.Atoi(v)
			if err != nil {
				panic("non number on token")
			}
			numbersStack = append(numbersStack, number)
		}
	}

	return numbersStack[0]

}

func isOperator(symbol string) bool {
	possibleOperators := map[string]bool{"+": true, "-": true, "*": true, "/": true}
	return possibleOperators[symbol]
}
