# Code Explanation ([Problem](https://leetcode.com/problems/design-an-ordered-stream/))

```csharp
private readonly PriorityQueue<string, int> _minHeap;
private int _pointer = 1;
```

- This section of code declares two private fields:
   - `_minHeap`: This is an instance of a custom data structure called `PriorityQueue`, which is designed to hold pairs of strings and integers. It represents a container for items with associated keys.
   - `_pointer`: This is an integer variable initialized to 1. It serves as a counter or pointer to keep track of the expected key for the next insertion.

```csharp
public DesignOrderedStream(int n)
{
    _minHeap = new PriorityQueue<string, int>(n);
}
```

- This is the constructor of the `DesignOrderedStream` class. It takes an integer `n` as a parameter but doesn't specify its purpose in this code snippet. Inside the constructor, it initializes the `_minHeap` field as a new `PriorityQueue<string, int>` with a specified capacity of `n`. This suggests that `n` might represent the maximum capacity of the data structure.

```csharp
public IList<string> Insert(int idKey, string value)
{
    _minHeap.Enqueue(value, idKey);
    _minHeap.TryPeek(out var _, out var index);

    var result = new List<string>();
    while (index == _pointer)
    {
        result.Add(_minHeap.Dequeue());
        _pointer++;
        _minHeap.TryPeek(out var _, out index);
    }

    return result;
}
```

- This is the `Insert` method, responsible for adding elements to the data structure and retrieving an ordered sequence of elements.
   - `_minHeap.Enqueue(value, idKey)`: This line adds an element to the `_minHeap` priority queue. It associates the `value` with the `idKey`, ensuring that elements with lower `idKey` values will be dequeued first.
   - `_minHeap.TryPeek(out var _, out var index)`: This line attempts to peek at the element at the front of the priority queue without removing it. It retrieves the element and its associated key (`index`) and checks if it can be immediately dequeued.
   - `var result = new List<string>();`: This line initializes an empty list called `result`, which will store the ordered sequence of elements that can be dequeued.
   - The subsequent `while` loop continues as long as the `index` (the key of the front element in the priority queue) matches the `_pointer` (the expected key for the next insertion). Inside the loop:
      - `result.Add(_minHeap.Dequeue())`: This dequeues the front element from `_minHeap` and adds it to the `result` list.
      - `_pointer++`: After dequeuing an element, `_pointer` is incremented to indicate the expected key for the next insertion.
      - `_minHeap.TryPeek(out var _, out index)`: This line checks the key of the new front element in the priority queue to see if it can be dequeued.
- Finally, the `result` list, which contains the ordered sequence of elements, is returned as a list of strings.

In summary, this code defines a data structure for inserting elements with associated keys and retrieving them in ascending order of keys. The elements are stored in a priority queue (`_minHeap`), and the `_pointer` variable keeps track of the expected key for the next insertion. The `Insert` method adds elements to the structure and returns a list of strings representing the ordered sequence of dequeued elements.