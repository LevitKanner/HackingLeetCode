# Code Explanation ([Problem](https://leetcode.com/problems/longest-consecutive-sequence))

```csharp
var unique = new HashSet<int>(nums);
```
- We start by creating a special container called a HashSet, which we named `unique`.
- This HashSet will hold unique numbers from the input array `nums`.
- This step helps us quickly check whether a number exists in the array without any duplicates.

```csharp
var result = 0;
```
- We create a variable named `result` and set its initial value to 0.
- This variable will store the length of the longest subarray with consecutive elements.

```csharp
for (var i = 0; i < nums.Length; i++)
{
    // ...
}
```
- We begin a loop that goes through each number in the input array `nums`.

```csharp
if (unique.Contains(nums[i] - 1)) continue;
```
- Inside the loop, we check if the number that's one less than the current number exists in the `unique` HashSet.
- If it does exist, it means the current number is part of a longer consecutive sequence, so we skip this iteration using `continue`.

```csharp
var longest = 0;
while (unique.Contains(nums[i] + longest))
{
    longest++;
}
```
- We start another loop within the main loop.
- This inner loop helps us find the length of the consecutive sequence starting from the current number.
- We start with a variable `longest` set to 0.
- As long as the number obtained by adding `longest` to the current number exists in the `unique` HashSet, we increment `longest`.
- This loop calculates how many consecutive numbers are there after the current number.

```csharp
if (longest > result) result = longest;
```
- After the inner loop, we compare the length of the current consecutive sequence (`longest`) with the current value of `result`.
- If `longest` is greater than the current `result`, we update `result` to store the length of the longest consecutive sequence found so far.

```csharp
return result;
```
- After the main loop is done, we have found the length of the longest consecutive sequence among all the elements.
- We return the value stored in the `result` variable as the final output of the function.

