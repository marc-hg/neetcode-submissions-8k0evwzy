class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        def hours(piles: List[int], eat_rate:int):
            return sum([(p + eat_rate - 1)//eat_rate for p in piles])
        left, right = 1, max(piles)
        ans = right
        while left <= right:
            middle = left + (right - left) // 2
            if hours(piles, middle) <= h:
                ans = middle
                right = middle - 1
            else:
                left = middle + 1
        return ans
