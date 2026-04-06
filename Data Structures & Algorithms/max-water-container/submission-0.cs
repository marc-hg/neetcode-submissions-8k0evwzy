public class Solution {
    public int MaxArea(int[] nums)
    {
        var longestArea = 0;
        var length = nums.Length;
        for (var i = 0; i < length; i++)
        {
            for (var j = i + 1; j < length; j++)
            {
                var area = Math.Min(nums[i], nums[j]) * Math.Abs(j - i);
                longestArea = Math.Max(area, longestArea);
            }
        }

        return longestArea;
    }

}
