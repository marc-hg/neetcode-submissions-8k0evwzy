public class Solution {
    public bool hasDuplicate(int[] nums) {
        var foundNumbers = new HashSet<int>();
        return nums.Any(n => !foundNumbers.Add(n));
    }
}