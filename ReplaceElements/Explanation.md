# Code Explanation (Like you're 5) ([Problem](https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side))

**Line 1:**

```csharp
var currentLargest = -1;
```

Think of a special box where we'll keep track of the biggest toy we've seen so far. We start with the number -1 for now,
like a placeholder.

**Line 2:**

```csharp
for (var i = arr.Length - 1; i >= 0; i--)
```

Now, let's go through all the toys in the box, but we'll start from the last toy and go backwards. It's like looking at
the toys from the end of the line to the beginning.

**Line 3:**

```csharp
var currentElement = arr[i];
```

Each time we look at a toy, we'll call it the "current toy." We want to remember what this toy is.

**Line 4:**

```csharp
arr[i] = currentLargest;
```

Now, we take the current toy and put the biggest toy we've seen so far in its place. The special box with the biggest
toy helps us remember which toy is the biggest.

**Line 5:**

```csharp
currentLargest = Math.Max(currentElement, currentLargest);
```

We check if the current toy is bigger than the biggest toy we know. If it is, we replace the biggest toy in our special
box with this new big toy. We always want to keep track of the biggest toy.

**Line 7:**

```csharp
return arr;
```

After we've looked at all the toys and replaced them with bigger toys if needed, we put them back in the box and say, "
Here are the toys, all arranged nicely!"