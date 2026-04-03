public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numsHash = new HashSet<int>(nums);
        return nums.Length != numsHash.Count;        
    }
}