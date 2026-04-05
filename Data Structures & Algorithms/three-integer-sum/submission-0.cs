public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> triplets = [];
        Array.Sort(nums);
        for (var k = 0; k < nums.Length; k++)
        {
            if (k > 0 && nums[k] == nums[k - 1]) continue;
            int l = k+1, r = nums.Length-1;
            var target = -nums[k];
            while (l < r )
            {
                var sum = nums[l] + nums[r];
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
                if (sum == target)
                {
                    triplets.Add([nums[l], nums[r], nums[k]]);
                    r--;
                    l++;
    
                    // Skip duplicates for the left pointer ONLY AFTER a successful match
                    while (l < r && nums[l] == nums[l - 1])
                    {
                        l++;
                    }
                }

            }
        }
        return triplets;
    }
}
