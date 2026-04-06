public class Solution {
    public int MaxArea(int[] nums)
    {
        int l = 0, r = nums.Length-1;
        var longestArea = 0;
        while (l < r) 
        {
            var currentArea = Math.Min(nums[l], nums[r]) * (r - l);
            longestArea = Math.Max(longestArea, currentArea);
            
            // should increase l or decrease r?
            if (nums[l] < nums[r])
            {
                l++;
            }
            else
            {
                r--;
            }
        } 

        return longestArea;
    }


}
