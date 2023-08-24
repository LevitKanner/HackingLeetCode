namespace Leetcode.ReorganiseString;

public static class ReorganiseString
{
    public static string Run(string s)
    {
        Dictionary<char, int> characterCounts = new();
        foreach (var character in s)
        {
            if (characterCounts.TryGetValue(character, out var value))
            {
                characterCounts[character] = ++value;
                continue;
            }

            characterCounts[character] = 1;
        }

        PriorityQueue<(char, int), int> heap = new();
        foreach (var entry in characterCounts)
        {
            heap.Enqueue((entry.Key, -entry.Value), -entry.Value);
        }

        var result = "";
        (char, int)? mostRecent = null;

        while (heap.Count > 0 || mostRecent is not null)
        {
            if (heap.Count == 0 && mostRecent is not null)
            {
                return "";
            }

            var currentItem = heap.Dequeue();
            result += currentItem.Item1;
            currentItem.Item2++;

            if (mostRecent is not null)
            {
                heap.Enqueue(mostRecent.Value, mostRecent.Value.Item2);
                mostRecent = null;
            }

            if (currentItem.Item2 != 0)
            {
                mostRecent = currentItem;
            }
            
        }

        return result;
    }
}