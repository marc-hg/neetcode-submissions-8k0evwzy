public class Solution {
    public bool IsPalindrome(string word)
    {
        var left = 0;
        var right = word.Length - 1;
        while (left < right)
        {
            var leftC = char.ToLower(word[left]);
            var rightC = char.ToLower(word[right]);
            if (!char.IsLetterOrDigit(leftC))
            {
                left++;
                continue;
            }
            if (!char.IsLetterOrDigit(rightC))
            {
                right--;
                continue;
            }
            if (leftC != rightC) return false;
            left++;
            right--;
        }

        return true;

    }

}
