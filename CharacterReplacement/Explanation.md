# Code Explanation ([Problem](https://leetcode.com/problems/longest-repeating-character-replacement))

```csharp
var l = 0;
var result = 0;
var mostFreq = 0;
```

- We start by creating three variables: `l`, `result`, and `mostFreq`.
- `l` will help us keep track of the left end of a sliding window.
- `result` will store the length of the longest substring we find.
- `mostFreq` will keep track of the most frequent character within the sliding window.

```csharp
Dictionary<char, int> map = new();
```

- We create a dictionary called `map`. In this dictionary, we will store characters from the string `s` as keys and
  their respective counts as values.
- This will help us keep track of how many times each character appears within the sliding window.

```csharp
for (var i = 0; i < s.Length; i++)
{
    // ...
}
```

- We start a loop that goes through each character of the string `s`.

```csharp
if (map.ContainsKey(s[i]))
{
    map[s[i]] += 1;
}
else
{
    map[s[i]] = 1;
}
```

- Inside the loop, we check if the character `s[i]` is already in the `map` dictionary.
- If it's in the dictionary, we increment its count by 1.
- If it's not in the dictionary, we add it to the dictionary with a count of 1.
- This way, we keep track of how many times each character has appeared in the current sliding window.

```csharp
if (map[s[i]] > mostFreq) mostFreq = map[s[i]];
```

- After updating the character count in the `map`, we check if this character's count is greater than the
  current `mostFreq`.
- If it is, we update `mostFreq` to be the count of this character.
- This helps us keep track of the count of the most frequent character within the sliding window.

```csharp
while (i - l + 1 - mostFreq > k)
{
    map[s[l]]--;
    l++;
}
```

- We enter a while loop that runs as long as a certain condition is met.
- The condition `i - l + 1 - mostFreq > k` checks if the length of the current sliding window minus the count of the
  most frequent character exceeds the given value `k`.
- If this condition is true, it means we have too many characters to replace (more than `k`), and we need to shrink the
  window from the left side.
- Inside the loop, we decrement the count of the character at the left end `s[l]` in the `map`, and we move the left
  pointer `l` one step to the right.
- This loop effectively adjusts the sliding window to meet the constraint of replacing at most `k` characters.

```csharp
result = Math.Max(result, (i - l) + 1);
```

- After adjusting the sliding window, we calculate the length of the current window `(i - l) + 1` and take the maximum
  of this length and the current `result`.
- This ensures that `result` always holds the length of the longest valid substring found so far.

```csharp
return result;
```

- After processing all characters in the string, we return `result` as the final output.
- This `result` will be the length of the longest substring with at most `k` character replacements.

