public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        var uniqueNums = (new HashSet<int>(nums)).ToArray();
        Array.Sort(uniqueNums);
        if (uniqueNums.Length == 0) return 0;

        var longestStreak = 1;
        var currentStreak = 1;
        for (var i = 0; i < uniqueNums.Length-1; i++)
        {
            var currentValue = uniqueNums[i];
            var nextValue = uniqueNums[i + 1];
            if (nextValue == currentValue + 1)
            {
                currentStreak++;
            }
            else
            {
                currentStreak = 1;
            }

            if (currentStreak > longestStreak)
            {
                longestStreak = currentStreak;
            }
        }

        return longestStreak;
    }

}
