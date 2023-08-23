namespace Leetcode.ReplaceElements;

public static class ReplaceElement
{
    public static int[] Run(int[] arr)
    {
        var currentLargest = -1;
        for (var i = arr.Length - 1; i >= 0; i--)
        {
            var currentElement = arr[i];
            arr[i] = currentLargest;
            currentLargest = Math.Max(currentElement, currentLargest);
        }

        return arr;
    }
}