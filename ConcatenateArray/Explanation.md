# Code Explanation ([Problem](https://leetcode.com/problems/concatenation-of-array/))

```csharp
var result = new int[nums.Length * 2];
```

- This line creates a new integer array called `result`. It's being initialized with a length of `nums.Length * 2`,
  which means it will have twice the length of the original `nums` array.
- In other words, it's making space for the elements of the `nums` array to be repeated twice in the `result` array.

```csharp
for (var i = 0; i < nums.Length * 2; i++) {
    result[i] = nums[i % nums.Length];
}
```

- This is a loop that will run `nums.Length * 2` times. In each iteration, it performs the following actions:
    - It assigns the value of `nums[i % nums.Length]` to the `result[i]` element.
    - The expression `i % nums.Length` calculates the remainder (`%` operator) when dividing `i` by the length of
      the `nums` array.
    - This effectively cycles through the elements of the `nums` array. When `i` reaches a value greater than or equal
      to `nums.Length`, it wraps around to the beginning of the `nums` array using the remainder.
    - This way, the elements of the `nums` array are repeated in the `result` array, creating the effect of doubling the
      array.

```csharp
return result;
```

- After the loop completes, the modified `result` array is returned.
- This array now contains the elements of the original `nums` array repeated twice in a row.