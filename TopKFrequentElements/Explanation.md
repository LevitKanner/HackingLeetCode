# Code Explanation ([Problem](https://leetcode.com/problems/top-k-frequent-elements))

The problem is about finding the `k` most frequent elements in an array.

```csharp
var result = new int[k];
```

- We create an array named `result` with a length of `k`.
- This array will store the top `k` frequent elements.

```csharp
Dictionary<int, int> numberCounts = new();
```

- We create a dictionary called `numberCounts` to keep track of how many times each number appears in the input array.
- The keys in this dictionary will be the numbers, and the values will be the corresponding counts of those numbers.

```csharp
foreach (var number in nums)
{
    // ...
}
```

- We loop through each number in the input array `nums`.

```csharp
if (numberCounts.TryGetValue(number, out var count))
{
    numberCounts[number] = ++count;
}
else
{
    numberCounts[number] = 1;
}
```

- Inside the loop, we check if the current `number` is already a key in the `numberCounts` dictionary.
- If it is, we increment the count of that number.
- If it's not, we add a new entry for that number with a count of 1.

```csharp
PriorityQueue<int, int> queue = new();
```

- We create a priority queue called `queue`. This data structure is used to keep elements in a specific order based on
  their priorities.

```csharp
foreach (var entry in numberCounts)
{
    queue.Enqueue(entry.Key, -entry.Value);
}
```

- We loop through each entry (key-value pair) in the `numberCounts` dictionary.
- For each entry, we enqueue the number (key) into the priority queue with a priority that's the negative of its count (
  value).
- This is done to ensure that the priority queue orders elements by their frequency in descending order.

```csharp
var i = 0;
while (i < k)
{
    result[i] = queue.Dequeue();
    i++;
}
```

- We initialize a variable `i` to keep track of how many elements we've dequeued.
- We enter a loop that continues until we've dequeued `k` elements.
- Inside the loop, we dequeue an element from the priority queue and store it in the `i`-th position of the `result`
  array.
- We increment `i` after each dequeue.

```csharp
return result;
```

- After dequeuing the top `k` frequent elements and storing them in the `result` array, we return the `result` array as
  the final output of the function.

In summary, this code uses a dictionary to count the occurrences of numbers in the input array, a priority queue to keep
track of the most frequent numbers, and an array to store the top `k` frequent elements.