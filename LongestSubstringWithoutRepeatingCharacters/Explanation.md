# Code Explanation ([Problem](https://leetcode.com/problems/longest-substring-without-repeating-characters/))
```csharp
if (s.Length < 2) return s.Length;
```
- If the length of the given string `s` is less than 2 characters, then there's no need to check for repeated characters because a single-character or empty string can't have repeated characters. So, in this case, we directly return the length of the string.

```csharp
int l = 0, r = 0, result = 0;
HashSet<char> memory = new();
```
- We create three variables, `l`, `r`, and `result`, and set them all to 0 initially.
- `l` and `r` are pointers that will help us keep track of a window of characters in the string.
- We also create a "memory" container called a HashSet to remember which characters we've seen so far.

```csharp
while (r < s.Length)
{
    // ...
}
```
- We start a loop that continues as long as the right pointer `r` is within the bounds of the string length.

```csharp
if (!memory.Contains(s[r]))
{
    memory.Add(s[r]);
    r++;
    result = Math.Max(result, memory.Count);
}
```
- Inside the loop, we check if the character at the current right pointer `r` is not already in our memory (HashSet).
- If it's not in memory, we add it to memory and move the right pointer `r` to the next character.
- We also update the `result` to be the maximum of its current value and the count of characters in memory. This helps us keep track of the longest substring without repeating characters.

```csharp
else
{
    memory.Remove(s[l]);
    l++;
}
```
- If the character at the right pointer `r` is already in memory, we remove the character at the left pointer `l` from memory and move the left pointer `l` to the right.
- This effectively shrinks the window to find the next potential substring without repeating characters.

```csharp
return result;
```
- After the loop finishes, we've found the length of the longest substring without repeating characters.
- We return this length as the final output of the function.