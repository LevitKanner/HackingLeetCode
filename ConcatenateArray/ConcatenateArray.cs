namespace Leetcode.ConcatenateArray;

public static class GetConcatenation
{
    public static int[] Run(int[] nums)
    {
        var result = new int[nums.Length * 2];

        for (var i = 0; i < nums.Length * 2; i++) result[i] = nums[i % nums.Length];
        return result;
    }
}