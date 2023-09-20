# Code Explanation ([Problem](https://leetcode.com/problems/group-anagrams))

Anagrams are words that have the same letters but in a different order. The goal is to organize these anagrams into
separate groups. Let's break down the code step by step:

```csharp
Dictionary<string, List<string>> groups = new();
```

Here, we're creating a special box called a dictionary. In this problem, the dictionary will hold groups of anagrams.
Each group will have a "key" which is a string representing the letters of the anagrams in sorted order. And the "value"
will be a list of actual anagrams.

```csharp
foreach (var word in strs)
{
    var orderedWord = string.Concat(word.Order());
    // ...
}
```

We're looping through each word in the given list of words (`strs`). For each word, we're creating a new string
called `orderedWord` by sorting its letters. This sorted word will be used as a key to group anagrams together.

```csharp
if (groups.TryGetValue(orderedWord, out var value))
{
    value.Add(word);
}
else
{
    groups[orderedWord] = new List<string> { word };
}
```

Here, we're checking if the `orderedWord` is already a key in our dictionary (`groups`). If it is, we retrieve the
corresponding list of anagrams (`value`) and add the current word to that list. If it's not already a key, we create a
new list containing the current word and assign it to the `orderedWord` in the dictionary.

The loop continues through all the words, organizing them into groups based on their sorted letters.

```csharp
return groups.Values.ToList();
```

After processing all the words, we're done organizing the anagrams into groups using the dictionary. Now, we're
interested in the lists of anagrams (the values) in the dictionary. We extract these lists and put them into a new list.
Finally, we return this list of anagram groups as the result.

In summary, the code efficiently groups anagrams together by sorting the letters of each word and using the sorted word
as a key in a dictionary. The values of the dictionary are lists of anagrams that share the same sorted word key. The
final result is a list of lists, where each inner list contains a group of anagrams.