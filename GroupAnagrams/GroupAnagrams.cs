namespace Leetcode.GroupAnagrams;

public static class GroupAnagrams
{
    public static List<List<string>> Run(string[] strs)
    {
        Dictionary<string, List<string>> groups = new();
        foreach (var word in strs)
        {
            var orderedWord = string.Concat(word.Order());
            if (groups.TryGetValue(orderedWord, out var value))
            {
                value.Add(word);
            }
            else
            {
                groups[orderedWord] = new List<string> { word };
            }
        }

        return groups.Values.ToList();
    }
}