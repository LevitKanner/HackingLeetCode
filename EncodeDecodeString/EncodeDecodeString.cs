using System.Text;

namespace Leetcode.EncodeDecodeString;

public static class EncodeDecodeString
{
    public static string Encode(List<string> strs)
    {
        var builder = new StringBuilder();
        foreach (var word in strs) builder.Append($"{word.Length}#{word}");

        return builder.ToString();
    }

    public static List<string> Decode(string str)
    {
        var l = 0;
        var result = new List<string>();
        var wordLength = "";
        while (l < str.Length)
            if (str[l] != '#')
            {
                wordLength += str[l];
                l++;
            }
            else
            {
                var parsedLength = int.Parse(wordLength);
                var word = str[(l + 1) .. (l + parsedLength + 1)];
                result.Add(word);
                l += parsedLength + 1;
                wordLength = "";
            }

        return result;
    }
}