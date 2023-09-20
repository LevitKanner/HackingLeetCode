namespace Leetcode.ValidAnagram;

/// <summary>
///     <see href="https://leetcode.com/problems/valid-anagram/description/" />
///     Given two strings s and t, return true if t is an anagram of s, and false otherwise.
///     An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all
///     the original letters exactly once.
///     <example>
///         Example 1:
///         Input: s = "anagram", t = "nagaram"
///         Output: true
///     </example>
/// </summary>
public static class ValidaAnagram
{
    public static bool Run(string s, string t)
    {
        if (s.Length != t.Length) return false;
        if (s == t) return true;

        Dictionary<char, int> sLetterCount = new();
        Dictionary<char, int> tLetterCount = new();
        for (var i = 0; i < s.Length; i++)
        {
            if (sLetterCount.ContainsKey(s[i]))
                sLetterCount[s[i]] += 1;
            else
                sLetterCount[s[i]] = 1;

            if (tLetterCount.ContainsKey(t[i]))
                tLetterCount[t[i]] += 1;
            else
                tLetterCount[t[i]] = 1;
        }

        return !sLetterCount.Any(
            entry => !tLetterCount.ContainsKey(entry.Key) || tLetterCount[entry.Key] != entry.Value);
    }
}