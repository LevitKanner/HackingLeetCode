namespace Leetcode.CharacterReplacement;

public static class CharacterReplacement
{
    public static int Run(string s, int k)
    {
        var l = 0;
        var result = 0;
        var mostFreq = 0;
        
        Dictionary<char, int> map = new();
        for (var i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                map[s[i]] += 1;
            }
            else
            {
                map[s[i]] = 1;
            }

            if (map[s[i]] > mostFreq) mostFreq = map[s[i]];
            
            while (i - l + 1 - mostFreq > k)
            {
                map[s[l]]--;
                l++;
            }

            result = Math.Max(result, (i - l) + 1);
        }

        return result;
    }
}