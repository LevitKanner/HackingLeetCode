# Explanation of Code

```csharp
HashSet<int> checkedList = new();
```

- This line declares a `HashSet` called `checkedList` that will store unique integer values that have been encountered
  during the iteration. A `HashSet` is a data structure that allows for fast insertion, deletion, and lookup operations
  with O(1) average time complexity.

```csharp
foreach (var num in nums)
{
    if (checkedList.Contains(num)) return true;
    checkedList.Add(num);
}
```

- This loop iterates through each integer `num` in the `nums` collection (presumably an array or a similar structure).
    - `if (checkedList.Contains(num)) return true;`: This condition checks if the current integer `num` already exists
      in the `checkedList` HashSet. If it does, it means that this integer has been encountered before, indicating the
      presence of a duplicate. In this case, the function immediately returns `true`, indicating that there are
      duplicates in the input array.
    - `checkedList.Add(num);`: If the current integer `num` is not already in the `checkedList`, this line adds it to
      the HashSet, marking it as "checked" for future iterations.

```csharp
return false;
```

- If the loop completes without finding any duplicate integers in the `nums` collection, the function returns `false`,
  indicating that there are no duplicates.

In summary, this uses a `HashSet` called `checkedList` to keep track of the integers encountered during the loop. If a
duplicate is encountered, the function returns `true`; otherwise, it returns `false` to indicate the absence of
duplicates. This algorithm has an average time complexity of O(n) due to the efficient operations of the `HashSet`.