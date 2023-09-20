# Code Explanation ([Problem](https://leetcode.com/problems/reorganize-string))

```csharp
Dictionary<char, int> characterCounts = new();
foreach (var character in s)
{
    if (characterCounts.TryGetValue(character, out var value))
    {
        characterCounts[character] = ++value;
        continue;
    }

    characterCounts[character] = 1;
}
```

1. A dictionary named `characterCounts` is created. This dictionary will store each unique character from the input
   string `s` as a key and its corresponding frequency as the associated value.

2. The code iterates through each character in the input string `s`.

3. For each character, it checks if the character is already present in the dictionary using the `TryGetValue` method.
   If the character is found (`TryGetValue` returns `true`), it increments the frequency stored in the dictionary by 1.

4. If the character is not found in the dictionary, it means this is the first occurrence of the character, so its
   frequency is set to 1.

```csharp
PriorityQueue<(char, int), int> heap = new();
foreach (var entry in characterCounts)
{
    heap.Enqueue((entry.Key, -entry.Value), -entry.Value);
}
```

1. A priority queue named `heap` is created. This priority queue is designed to hold tuples, where the first element of
   the tuple is a character, the second element is the negative frequency of that character, and the priority is the
   negative frequency as well.

2. The code iterates through each key-value pair in the `characterCounts` dictionary.

3. For each key-value pair, it creates a tuple with the character as the first element and the negative frequency as the
   second element. It then enqueues this tuple into the priority queue `heap`. The priority is set as the negative
   frequency, which means characters with higher frequency (the lower the priority value, the higher the
   priority [Good read on priority queues](https://code-maze.com/csharp-priority-queue/)) will have higher priority.

```csharp
var result = "";
(char, int)? mostRecent = null;

while (heap.Count > 0 || mostRecent is not null)
{
    if (heap.Count == 0 && mostRecent is not null)
    {
        return "";
    }

    var currentItem = heap.Dequeue();
    result += currentItem.Item1;
    currentItem.Item2++;

    if (mostRecent is not null)
    {
        heap.Enqueue(mostRecent.Value, mostRecent.Value.Item2);
        mostRecent = null;
    }

    if (currentItem.Item2 != 0)
    {
        mostRecent = currentItem;
    }
}
```

1. A string variable `result` is created to hold the rearranged characters based on their frequencies.

2. A nullable tuple `(char, int)? mostRecent` is declared to store the most recently dequeued character and its
   frequency.

3. The code enters a loop that continues as long as the priority queue `heap` is not empty or there are still characters
   to be processed in `mostRecent`.

4. Inside the loop, there is a conditional check. If the queue is empty but there's still a character in `mostRecent`,
   it means there are unprocessed characters but the queue has been exhausted. In this case, the function returns an
   empty string.

5. The code dequeues an item from the priority queue. The dequeued item contains the character and its negative
   frequency. The character is appended to the `result` string, and the frequency is incremented by 1.

6. If `mostRecent` is not null, meaning there is a character waiting to be re-enqueued, it is added back to the priority
   queue with its modified frequency. Then, `mostRecent` is set to null to indicate that the character has been
   processed.

7. If the frequency of the dequeued character is not zero, it becomes the new `mostRecent` character to be re-enqueued
   later.

8. The loop continues until the queue is empty and there are no characters left in `mostRecent`.

Finally:

```csharp
return result;
```

The rearranged string of characters based on their frequencies, with highly frequent characters appearing first, is
returned as the result.