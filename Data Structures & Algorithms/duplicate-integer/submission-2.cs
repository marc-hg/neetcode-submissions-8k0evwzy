public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numsHash = new HashSet<int>(nums);
        Console.WriteLine(numsHash.Count);
        return nums.Length != numsHash.Count;        
    }
}