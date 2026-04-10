

func evalRPN(tokens []string) int {
	possibleOperators := map[string]bool{"+": true, "-": true, "*": true, "/": true}
	var numbersStack []int
	for _, v := range tokens {
		if !(possibleOperators[v]) {
			number, err := strconv.Atoi(v)
			if err != nil {
				continue
			}
			numbersStack = append(numbersStack, number)
		} else if len(numbersStack) > 1 {
			y := numbersStack[len(numbersStack)-1]
			x := numbersStack[len(numbersStack)-2]
			operator := v
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
				continue
			}

			numbersStack = append(numbersStack, result)

		}
	}

	return numbersStack[0]

}
