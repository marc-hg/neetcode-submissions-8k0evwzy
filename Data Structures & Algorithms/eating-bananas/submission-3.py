class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        # sum_factor = len(piles)//h
        left = 1
        right = max(piles)
        best_value = 1

        while left <= right:
            middle = left + (right - left) // 2
            hour_experiment = self.hoursOrBurst(piles, middle, h)

            # -1 means hour burst so we gotta eat faster, increase value
            if hour_experiment == -1:
                left = middle + 1
            # if value works keep greedily decreasing value and save best value
            else:
                best_value = middle
                right = middle - 1

        return best_value

    def hoursOrBurst(self, piles: List[int], banana_eating_rate: int, time_limit: int) -> int:
        total_hours = 0
        for pile in piles:
            if pile < banana_eating_rate:
                time_to_eat_pile = 1
            else:
                time_to_eat_pile = pile // banana_eating_rate
                if pile % banana_eating_rate >= 1:
                    time_to_eat_pile += 1
            total_hours += time_to_eat_pile

            if total_hours > time_limit:
                return -1
        return total_hours
