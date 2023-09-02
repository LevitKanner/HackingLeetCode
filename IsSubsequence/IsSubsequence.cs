namespace Leetcode.IsSubsequence;

public static class IsSubsequence
{
    public static bool Run(string s, string t)
    {
        if (s.Length > t.Length) return false;
        if (s == t || s == "") return true;


        var sequences = 0;
        foreach (var character in t)
        {
            if (sequences < s.Length && s[sequences] == character)
            {
                sequences++;
            }
        }

        return sequences == s.Length;
    }
}