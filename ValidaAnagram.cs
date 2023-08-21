namespace Leetcode;

public static class ValidaAnagram
{
   public static bool Run(string s, string t)
   {
      if (s.Length != t.Length) return false;
      if (s == t) return true;
      
      Dictionary<char, int> sLetterCount = new();
      Dictionary<char, int> tLetterCount = new();
      for (var i = 0; i < s.Length; i++)
      {
         if (sLetterCount.ContainsKey(s[i]))
         {
            sLetterCount[s[i]] += 1;
         }
         else
         {
            sLetterCount[s[i]] = 1;
         }
         
         if (tLetterCount.ContainsKey(t[i]))
         {
            tLetterCount[t[i]] += 1;
         }
         else
         {
            tLetterCount[t[i]] = 1;
         }
      }
      
      return !sLetterCount.Any(entry => !tLetterCount.ContainsKey(entry.Key) || tLetterCount[entry.Key] != entry.Value);
   }
}