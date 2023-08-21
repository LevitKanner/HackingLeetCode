namespace Leetcode;

public static class ContainsDuplicate
{
    public static bool Run(int[] nums)
    {
        HashSet<int> checkedList = new();

        foreach (var num in nums)
        {
            if (checkedList.Contains(num)) return true;
            checkedList.Add(num);
        }

        return false;
    }
}