# Code Explanation ([Problem](https://leetcode.com/problems/design-an-ordered-stream/))

```csharp
private readonly PriorityQueue<string, int> _minHeap;
private int _pointer = 1;
```

- This section of code declares two private fields:
   - `_minHeap`: This is an instance of a `PriorityQueue`, which is designed to hold pairs of strings and integers(which represents their priority).
   - `_pointer`: This is an integer variable initialized to 1. It serves as a pointer to keep track of the expected key for removal.

```csharp
public DesignOrderedStream(int n)
{
    _minHeap = new PriorityQueue<string, int>(n);
}
```

- This is the constructor of the `DesignOrderedStream` class. It takes an integer `n` as a parameter which indicates the initial capacity of the heap. Inside the constructor, it initializes the `_minHeap` field as a new `PriorityQueue<string, int>` with a specified capacity of `n`.

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

- This is the `Insert` method, responsible for adding elements to the heap and retrieving an ordered sequence of elements.
   - `_minHeap.Enqueue(value, idKey)`: This line adds an element to the heap. It associates the `value` with the `idKey`, ensuring that elements with lower `idKey` values will be dequeued first.
   - `_minHeap.TryPeek(out var _, out var index)`: This line attempts to peek at the element at the front of the priority queue without removing it. It retrieves the element and its associated key (`index`) and checks if it can be immediately dequeued.
   - `var result = new List<string>();`: This line initializes an empty list called `result`, which will store the ordered sequence of elements that can be dequeued.
   - The subsequent `while` loop continues as long as the `index` (the key of the front element in the priority queue) matches the `_pointer` (the expected key for the next removal). Inside the loop:
      - `result.Add(_minHeap.Dequeue())`: This dequeues the front element from `_minHeap` and adds it to the `result` list.
      - `_pointer++`: After dequeuing an element, `_pointer` is incremented to indicate the expected key for the next removal.
      - `_minHeap.TryPeek(out var _, out index)`: This line checks the key of the new front element in the priority queue to see if it can be dequeued.
- Finally, the `result` list, which contains the ordered sequence of elements, is returned as a list of strings.
