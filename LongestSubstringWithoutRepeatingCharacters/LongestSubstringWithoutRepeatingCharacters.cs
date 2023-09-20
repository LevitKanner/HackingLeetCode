namespace Leetcode.LongestSubstringWithoutRepeatingCharacters;

public static class LongestSubstringWithoutRepeatingCharacters
{
    public static int Run(string s)
    {
        if (s.Length < 2) return s.Length;

        int l = 0, r = 0, result = 0;
        HashSet<char> memory = new();

        while (r < s.Length)
            if (!memory.Contains(s[r]))
            {
                memory.Add(s[r]);
                r++;
                result = Math.Max(result, memory.Count);
            }
            else
            {
                memory.Remove(s[l]);
                l++;
            }

        return result;
    }
}