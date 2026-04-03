public class Solution {

    private const string Separator = "—";
    private const string Empty = "¶";
    private const string EmptyString = "¤";

    public string Encode(IList<string> strs)
    {
        if (strs.Count == 0) return Empty;
        var curatedStrs = strs.Select(s => s == "" ? EmptyString : s);
        return string.Join(Separator, curatedStrs);
    }

    
    public List<string> Decode(string s)
    {
        if (s == Empty) return [];
        var strs = s.Split(Separator);
        return strs.Select(str => str == EmptyString ? "": str).ToList();
    }


}
