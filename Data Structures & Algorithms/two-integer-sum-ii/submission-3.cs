public class Solution {
    public int[] TwoSum(int[] numbers, int target)
    {
        int l = 0, r = numbers.Length - 1;
        while (l < r)
        {
            var sum = numbers[l] + numbers[r];
            if (sum > target)
            {
                r--;
                continue;
            }
            if (sum < target)
            {
                l++;
                continue;
            }
            if (sum == target) return [l+1, r+1];

        }
        return [-1,-1];
    }

}
