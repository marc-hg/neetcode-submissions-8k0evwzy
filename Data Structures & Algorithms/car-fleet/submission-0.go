

type Car struct {
	position int
	speed    int
}

func carFleet(target int, position []int, speed []int) int {
	// Create car array
	cars := make([]Car, len(position))
	for i := range position {
		cars[i] = Car{
			position: position[i],
			speed:    speed[i],
		}
	}

	// Sort car array
	sort.Slice(cars, func(i, j int) bool {
		return cars[i].position > cars[j].position
	})

	var count int
	var maxTime float64
	for _, car := range cars {
		currentTime := float64(target-car.position) / float64(car.speed)
		if currentTime > maxTime {
			count++
			maxTime = currentTime
		}
	}
	return count
}
