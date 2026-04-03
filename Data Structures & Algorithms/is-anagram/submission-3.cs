public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false; 
        var unorderedWord1 = new UnorderedList(s);
        var unorderedWord2 = new UnorderedList(t);

        return unorderedWord1.Equals(unorderedWord2);

    }
}


public class UnorderedList
{
    private readonly Dictionary<char, int> _unorderedChars = new Dictionary<char, int>();

    public UnorderedList(string word1)
    {
        foreach (var c in word1)
        {
            var firstAdd = _unorderedChars.TryAdd(c, 1);
            if (!firstAdd)
            {
                _unorderedChars[c]++;
            }
        }
    }

    public override bool Equals(object? obj)
    {
        if (obj is not UnorderedList unorderedList) return false;
        if (unorderedList._unorderedChars.Count != _unorderedChars.Count) return false;
        foreach (var keypair in _unorderedChars)
        {
            if (unorderedList._unorderedChars.TryGetValue(keypair.Key, out var value))
            {
                if (value != keypair.Value) return false;
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    public override int GetHashCode()
    {
        return _unorderedChars.Aggregate(0,
            (current, kvp) => current ^ (kvp.Key.GetHashCode() ^ kvp.Value.GetHashCode()));
    }
}