namespace Leetcode.ThreeSum;

public static class ThreeSum
{
    public static IList<IList<int>> Run(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<List<int>>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            var l = i + 1;
            var r = nums.Length - 1;
            while (r < l)
            {
                var sum = nums[i] + nums[l] + nums[l];
                switch (sum)
                {
                    case < 0:
                        l++;
                        break;
                    case > 0:
                        r--;
                        break;
                    default:
                        result.Add(new List<int> { nums[i], nums[l], nums[r] });
                        l++;
                        while (nums[l] == nums[l - 1] && l < r) l++;
                        break;
                }
            }
        }

        return result.ToArray();
    }
}