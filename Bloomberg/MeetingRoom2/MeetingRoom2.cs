namespace Leetcode.Bloomberg.MeetingRoom2;

public class MeetingRoom2
{
    public static int Run(int[][] intervals)
    {
        int[] ends = new int[intervals.Length], starts = new int[intervals.Length];

        for (var i = 0; i < intervals.Length; i++)
        {
            starts[i] = intervals[i][0];
            ends[i] = intervals[i][1];
        }

        Array.Sort(starts);
        Array.Sort(ends);

        var result = 0;

        var e = 0;
        foreach (var start in starts)
            if (start < ends[e])
                result++;
            else
                e++;

        return result;
    }
}