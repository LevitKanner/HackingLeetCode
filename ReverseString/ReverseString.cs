namespace Leetcode.ReverseString;

public static class ReverseString
{
    public static string Run(string s)
    {
        var chars = s.ToCharArray();

        var l = 0;
        var r = chars.Length - 1;
        while (l < r)
        {
            (chars[l], chars[r]) = (chars[r], chars[l]);
            l++;
            r--;
        }

        return string.Concat(chars);
    }
}