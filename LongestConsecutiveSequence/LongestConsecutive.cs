namespace Leetcode.LongestConsecutiveSequence;

public static class LongestConsecutive
{
    public static int Run(int[] nums)
    {
        var unique = new HashSet<int>(nums);
        var result = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (unique.Contains(nums[i] - 1)) continue;
            var longest = 0;
            while (unique.Contains(nums[i] + longest))
            {
                longest++;
            }

            if (longest > result) result = longest;
        }

        return result;
    }
}