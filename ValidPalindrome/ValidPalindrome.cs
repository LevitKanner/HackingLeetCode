namespace Leetcode.ValidPalindrome;

public static class ValidPalindrome
{
    public static bool Run(string s)
    {
        var i = 0;
        var j = s.Length - 1;
        var lowercased = s.ToLower();

        while (i < j)
        {
            if (!char.IsLetterOrDigit(lowercased[i]))
            {
                i++;
                continue;
            }

            if (!char.IsLetterOrDigit(lowercased[j]))
            {
                j--;
                continue;
            }

            if (lowercased[i] != lowercased[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}