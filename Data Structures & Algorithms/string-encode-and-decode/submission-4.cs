public class Solution {

    public string Encode(IList<string> strs)
    {
        var sb = new StringBuilder();
        foreach (var s in strs)
        {
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }
        return sb.ToString();
    }

    
    public List<string> Decode(string s)
    {
        List<string> decoded = [];

        var i = 0;
        while (i < s.Length)
        {
            // Obtain length
            var lengthSb = new StringBuilder();
            while (s[i] != '#')
            {
                lengthSb.Append(s[i]);
                i++;
            }

            int length = int.Parse(lengthSb.ToString());
            i++; // step over #

            var sb = new StringBuilder();
            for (var j = i; j < i + length; j++)
            {
                sb.Append(s[j]);
            }

            decoded.Add(sb.ToString());
            i+=length;
        }

        return decoded;
    }


}
