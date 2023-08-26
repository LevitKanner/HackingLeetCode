namespace Leetcode.TopKFrequentElements;

public static class TopKFrequentElements
{
    public static int[] Run(int[] nums, int k)
    {
        var result = new int[k];
        Dictionary<int, int> numberCounts = new();
        foreach (var number in nums)
        {
            if (numberCounts.TryGetValue(number, out var count))
            {
                numberCounts[number] = ++count;
            }
            else
            {
                numberCounts[number] = 1;
            }
        }

        PriorityQueue<int, int> queue = new();
        foreach (var entry in numberCounts)
        {
            queue.Enqueue(entry.Key, -entry.Value);
        }

        var i = 0;
        while (i < k)
        {
            result[i] = queue.Dequeue();
            i++;
        }

        return result;
    }
}