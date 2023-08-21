# Explanation of Code

This aims to solve the [problem](https://leetcode.com/problems/two-sum/) of finding two numbers in the `nums` array that sum up to the given `target` value. It does this efficiently using a dictionary to keep track of the numbers encountered so far, enabling a linear-time solution.

```csharp
Dictionary<int, int> numIndex = new();
```

- This line declares a variable `numIndex` and initializes it as an empty `Dictionary` where keys are of type `int` and values are of type `int`. This dictionary will be used to store the numbers from the `nums` array as keys and their corresponding indices as values.

```csharp
for (var i = 0; i < nums.Length; i++)
{
  var pair = target - nums[i];
  if (numIndex.TryGetValue(pair, out var value))
  {
    return new[] { value, i };
  }

  numIndex[nums[i]] = i;
}
```

- This loop iterates through each element of the `nums` array using the index `i`.
    - `var pair = target - nums[i];`: This line calculates the difference between `target` and the current element `nums[i]`, storing it in the `pair` variable. This difference represents the value that, when added to `nums[i]`, would result in the `target` value.
    - `if (numIndex.TryGetValue(pair, out var value))`: This `if` statement checks if the `pair` value exists as a key in the `numIndex` dictionary. If it does, it means that a number has been encountered earlier in the array that, when added to the current element, would equal the `target` value.
        - `out var value`: If the key is found in the dictionary, this line retrieves the associated value (index of the earlier encountered number) and stores it in the `value` variable.
        - `return new[] { value, i };`: This line returns an array containing the indices `value` (index of the earlier encountered number) and `i` (current index) as the solution to the problem, as we've found a pair of numbers that sum up to the `target`.

    - If the `pair` value is not found in the dictionary:
        - `numIndex[nums[i]] = i;`: This line adds the current element `nums[i]` as a key to the `numIndex` dictionary and associates it with the index `i`.

```csharp
return Array.Empty<int>();
```

- If no valid pair of indices is found during the loop, this line returns an empty array, indicating that no solution was found for the given `target` sum.

