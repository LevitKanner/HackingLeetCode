# Explanation ([Problem](https://leetcode.com/problems/minimum-window-substring))

We define a helper function called `AddToDictionary`.
```csharp
void AddToDictionary(Dictionary<char, int> map, char character) {
    if (map.ContainsKey(character)) {
        map[character]++;
    } else {
        map.Add(character, 1);
    }
}
```

- It takes two arguments: a dictionary called `map` and a character called `character`.
- Inside the function, it checks if the `map` already contains the `character`.
- If it does, it increments the count associated with that `character` in the `map`.
- If it doesn't, it adds the `character` to the `map` with a count of 1.

```csharp
public string MinWindow(string s, string t) {
```
- This is the start of a function called `MinWindow`.
- It takes two strings, `s` and `t`, as input.

```csharp
Dictionary<char, int> tMap = new();
```
- Here, a dictionary called `tMap` is created. This dictionary will be used to keep track of the characters in string `t` and their frequencies.

```csharp
foreach (var character in t)
{
    AddToDictionary(tMap, character);
}
```
- This loop iterates through each character in string `t`.
- For each character, it calls the `AddToDictionary` function to add it to the `tMap` dictionary.

```csharp
var need = tMap.Count;
```
- We count how many unique characters are in string `t` and store it in the variable `need`.
- This represents the total number of different characters we need to find in string `s`.

```csharp
int l = 0, have = 0, resultLength = int.MaxValue;
var pointers = (-1, -1);
Dictionary<char, int> window = new();
```
- We initialize several variables:
    - `l` is the left pointer of a sliding window.
    - `have` keeps track of how many required characters we have found.
    - `resultLength` is set to the maximum integer value initially; it will store the length of the minimum window found.
    - `pointers` is a tuple that stores the start and end indices of the minimum window.
    - `window` is a dictionary that keeps track of characters and their counts in the current window.

```csharp
for (var r = 0; r < s.Length; r++)
{
    var currentCharacter = s[r];
    AddToDictionary(window, currentCharacter);
```
- We start a loop that goes through each character in string `s`, using the right pointer `r`.
- For each character, we call the `AddToDictionary` function to add it to the `window` dictionary.

```csharp
if (tMap.TryGetValue(currentCharacter, out var value) && value == window[currentCharacter])
{
    have++;
}
```
- We check if the current character in `s` is also present in `t` by using the `TryGetValue` method on the `tMap` dictionary.
- If it is, we compare the count of that character in `tMap` (how many times it appears in `t`) with its count in the `window` dictionary (how many times it appears in the current window of `s`).
- If these counts match, we increment the `have` variable, indicating that we have found another required character.

```csharp
while (have == need)
{
    var windowLength = (r - l) + 1;
    if (windowLength < resultLength)
    {
        resultLength = windowLength;
        pointers = (l, r);
    }
```
- We enter a while loop that runs when we have found all the required characters in the current window.
- Inside this loop, we calculate the length of the current window and store it in `windowLength`.
- If `windowLength` is smaller than the current `resultLength`, we update `resultLength` to be the smaller value, and we store the indices of this minimum window in the `pointers` tuple.

```csharp
window[s[l]]--;
if (tMap.TryGetValue(s[l], out var count) && count > window[s[l]])
{
    have--;
}
l++;
```
- Inside the while loop, we move the left pointer `l` one step to the right.
- We decrement the count of the character at the left end of the window in the `window` dictionary.
- We also check if this character is in `t` by using the `TryGetValue` method on the `tMap` dictionary.
- If it is, and if the count of this character in the `window` dictionary is now less than the count in the `tMap`, we decrement the `have` variable because we've removed one of the required characters.

```csharp
return resultLength == int.MaxValue ? "" : s.Substring(pointers.Item1, pointers.Item2 - pointers

.Item1 + 1);
```
- After processing all characters in `s`, we check if `resultLength` is still equal to its initial maximum value (`int.MaxValue`).
- If it is, it means we didn't find any valid window, so we return an empty string.
- If it's not equal to `int.MaxValue`, we return the substring of `s` starting from the left index stored in `pointers.Item1` and ending at the right index stored in `pointers.Item2`, inclusive.
- This substring represents the minimum window that contains all required characters from `t`.
