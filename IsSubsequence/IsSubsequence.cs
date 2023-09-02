namespace Leetcode.IsSubstring;

public static class IsSubsequence
{
    public static bool Run(string s, string t)
    {
        if (s.Length > t.Length) return false;
        if (s == t) return true;


        var sequences = 0;
        for (var i = 0; i < t.Length; i++)
        {
            if (s[sequences] == t[i])
            {
                sequences++;
            }
        }

        return sequences == s.Length;
    }
}