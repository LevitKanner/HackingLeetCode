namespace Leetcode.RemoveDuplicatesSortedArray;

public static class RemoveDuplicates
{
    public static int Run(int[] nums)
    {
        if (nums.Length < 2) return nums.Length;
        var l = 0;
        var r = 1;
        while (r < nums.Length)
        {
            if (nums[l] != nums[r])
            {
                l++;
                nums[l] = nums[r];
            }

            r++;
        }

        return l + 1;
    }
}