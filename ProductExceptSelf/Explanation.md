# Code Explanation ([Problem](https://leetcode.com/problems/product-of-array-except-self))

```csharp
var result = new int[nums.Length];
```

We create an array called `result` with the same length as the input array `nums`. This array will store the final
values we want to compute.

```csharp
var prefix = 1;
for (var i = 0; i < nums.Length; i++)
{
    result[i] = prefix;
    prefix *= nums[i];
}
```

We start a loop that goes through each number in the input array `nums`. For each number, we do the following:

- We assign the current value of `prefix` to the current position in the `result` array.
- We then multiply the `prefix` by the current number from the input array.
  This loop calculates the product of all the numbers to the left of the current number and stores it in the `result`
  array.

```csharp
var postfix = 1;
for (var i = nums.Length - 1; i >= 0; i--)
{
    result[i] *= postfix;
    postfix *= nums[i];
}
```

We start another loop that goes through each number in the input array `nums`, but this time in reverse order (from
right to left). For each number, we do the following:

- We multiply the current value in the `result` array by the current value of `postfix`.
- We then multiply the `postfix` by the current number from the input array.
  This loop calculates the product of all the numbers to the right of the current number and updates the values in
  the `result` array accordingly.

```csharp
return result;
```

After both loops have finished running, we've essentially computed the product of all the numbers except the current
number itself and stored it in the `result` array. So, we return the `result` array as the final output.

