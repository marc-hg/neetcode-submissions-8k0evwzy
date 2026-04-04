public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0, r = numbers.Length - 1;
        while (l < r)
        {
            var left = numbers[l];
            var right = numbers[r];
            if (left + right > target)
            {
                r--;
                continue;
            }

            if (left + right < target)
            {
                l++;
                continue;
            }
            if (left + right == target) return [l+1, r+1];

        }
        return [-1,-1];
        
    }
}
