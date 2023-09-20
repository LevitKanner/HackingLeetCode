# Code Explanation ([Problem](https://leetcode.com/problems/reverse-string/))

```csharp
var chars = s.ToCharArray();
```

- We start by taking a string `s` and converting it into an array of characters called `chars`.
- This array will store each character of the string as a separate element.

```csharp
var l = 0;
var r = chars.Length - 1;
```

- We create two variables `l` and `r`. These will help us swap characters from the beginning (`l`) and the end (`r`) of
  the `chars` array.

```csharp
while (l < r)
{
    (chars[l], chars[r]) = (chars[r], chars[l]);
    l++;
    r--;
}
```

- We enter a loop that continues as long as `l` is less than `r`. This loop helps us reverse the order of characters in
  the `chars` array.
- Inside the loop, we use a special syntax to swap the characters at positions `l` and `r`. This is a concise way to
  exchange their values.
- After swapping, we move `l` one step to the right and `r` one step to the left, effectively working towards the center
  of the array.

```csharp
return string.Concat(chars);
```

- After the loop, we've reversed the characters in the `chars` array.
- Finally, we convert the array of characters back to a string using `string.Concat()`.
- This reversed string is then returned as the final output of the function.

In simple terms, this code takes a string `s`, reverses its characters, and returns the reversed string. It achieves
this by converting the string to an array of characters, then using a two-pointer approach (`l` and `r`) to swap
characters from the beginning and the end of the array, effectively reversing the order of characters. Finally, it
converts the reversed character array back into a string.