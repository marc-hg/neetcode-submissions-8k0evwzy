public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var seenNumbers = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var targetValue = target - nums[i];
            if (seenNumbers.TryGetValue(targetValue, out var position))
            {
                return [position, i];
            }
            seenNumbers.TryAdd(nums[i], i);
        }

        return [-1, -1];
    }

}
