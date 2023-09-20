namespace Leetcode.TwoSum;

public static class TwoSum
{
    public static int[] Run(int[] nums, int target)
    {
        Dictionary<int, int> numIndex = new();

        for (var i = 0; i < nums.Length; i++)
        {
            var pair = target - nums[i];
            if (numIndex.TryGetValue(pair, out var value)) return new[] { value, i };

            numIndex[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}