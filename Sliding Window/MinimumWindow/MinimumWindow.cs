namespace Leetcode.Sliding_Window.MinimumWindow;

public static class MinimumWindow
{
    public static string Run(string s, string t)
    {
        Dictionary<char, int> tMap = new();
        foreach (var character in t)
        {
            AddToDictionary(tMap, character);
        }

        var need = tMap.Count;


        int l = 0, have = 0, resultLength = int.MaxValue;
        var pointers = (-1, -1);
        Dictionary<char, int> window = new();

        for (var r = 0; r < s.Length; r++)
        {
            var currentCharacter = s[r];
            AddToDictionary(window, currentCharacter);

            if (tMap.TryGetValue(currentCharacter, out var value) && value == window[currentCharacter])
            {
                have++;
            }

            while (have == need)
            {
                var windowLength = (r - l) + 1;
                if (windowLength < resultLength)
                {
                    resultLength = windowLength;
                    pointers = (l, r);
                }

                window[s[l]]--;
                if (tMap.TryGetValue(s[l], out var count) && count < tMap[s[l]])
                {
                    have--;
                }

                l++;
            }
        }

        return resultLength == int.MaxValue ? "" : s.Substring(pointers.Item1, pointers.Item2 - pointers.Item1 + 1);
    }

    private static void AddToDictionary(IDictionary<char, int> map, char character)
    {
        if (map.TryGetValue(character, out var value))
        {
            map[character] = ++value;
        }
        else
        {
            map.Add(character, 1);
        }
    }
}