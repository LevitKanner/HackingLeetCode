# Code Explanation ([Problem](https://leetcode.com/problems/best-time-to-buy-and-sell-stock))

```csharp
var l = 0;
var r = 1;
```

- We create two variables, `l` and `r`, and set their initial values.
- `l` stands for "left" and `r` stands for "right". These are pointers that help us keep track of buying and selling
  days.

```csharp
var result = 0;
```

- We create a variable named `result` and set its initial value to 0.
- This variable will store the maximum profit that can be achieved by buying and selling the stock.

```csharp
while (r < prices.Length)
{
    // ...
}
```

- We start a loop that continues as long as `r` is less than the length of the `prices` array.
- This loop will help us go through each day's stock price to find the best buying and selling days.

```csharp
if (prices[l] < prices[r])
{
    var profit = prices[r] - prices[l];
    if (profit > result) result = profit;
}
else
{
    l = r;
}
```

- Inside the loop, we compare the stock price on day `l` (buying day) with the price on day `r` (selling day).
- If the price on day `l` is less than the price on day `r`, it means there's a possibility of profit.
- We calculate the profit by subtracting the buying price from the selling price.
- If this profit is greater than the current `result`, we update `result` to store this new maximum profit.
- If the price on day `l` is not less than the price on day `r`, it means we should reset the buying day to the current
  day (`r`), as it's better to start again looking for a new buying opportunity.

```csharp
r++;
```

- After processing the current day, we move both pointers one step forward by incrementing `r`.

```csharp
return result;
```

- Once the loop finishes, we have found the maximum profit achievable by buying and selling the stock.
- We return the value stored in the `result` variable as the final output of the function.

