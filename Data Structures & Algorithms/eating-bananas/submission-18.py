class Solution:
    # [1,4,3,2]
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        def Feasable(eat_speed:int):
            hours_taken = sum([(p + eat_speed - 1) // eat_speed for p in piles])
            hour_limit = h
            return hours_taken <= hour_limit # if  
            
        low, high = 1, max(piles)
        k = high
        while low <= high:
            mid = low + (high - low)//2
            if Feasable(mid): # greedy
                k = mid
                high = mid - 1
            else:
                low = mid + 1

        return k
