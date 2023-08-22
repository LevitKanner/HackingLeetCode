# Code Explanation ([Problem](https://leetcode.com/problems/remove-duplicates-from-sorted-array))

```csharp
if (nums.Length < 2) return nums.Length;
```

- `if (nums.Length < 2)` checks if the length of the array `nums` is less than 2.
- If the condition is true (meaning there are 1 or 0 elements in the array), it immediately returns the length of the array (`nums.Length`). This is because, in a sorted array, if there are 1 or 0 unique elements, the resulting length would be the same after removing duplicates.

```csharp
var l = 0;
var r = 1;
```

- These lines declare and initialize two variables `l` and `r`.
- `l` represents the left index of the portion of the array where unique elements are stored.
- `r` represents the right index that is used to traverse through the array to find duplicates.

```csharp
while (r < nums.Length)
{
    if (nums[l] != nums[r])
    {
        l++;
        nums[l] = nums[r];
    }

    r++;
}
```

- This is a loop that iterates over the array as long as the index `r` is less than the length of the array.
- Inside the loop, it checks if the element at index `l` is different from the element at index `r`. This comparison checks if the current element is a duplicate.
- If the elements are different, it means a new unique element is found. So, the `l` index is moved one step to the right, and the value at index `r` is assigned to `nums[l]`, effectively overwriting the duplicate element at `l` with the unique element at `r`.
- Regardless of whether the elements are the same or different, `r` is incremented to move on to the next element in the array.

```csharp
return l + 1;
```

- After the loop completes, it means all the unique elements have been moved to the beginning of the array up to index `l`.
- `l` now represents the index of the last unique element in this rearranged portion of the array.
- Adding 1 to `l` gives the count of unique elements, since array indices are zero-based.
- The function returns this count, indicating the number of unique elements in the array.
