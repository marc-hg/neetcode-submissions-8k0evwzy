public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        var uniqueNums = new HashSet<int>(nums);
        var longestStreak = 0;
        foreach (var num in uniqueNums)
        {
            var notFirstInSequence = uniqueNums.Contains(num - 1);
            if (notFirstInSequence) continue;

            var currentStreak = 1;
            while (uniqueNums.Contains(num+currentStreak))
            {
                currentStreak++;
            }

            if (currentStreak > longestStreak) longestStreak = currentStreak;
        }

        return longestStreak;
    }
}
