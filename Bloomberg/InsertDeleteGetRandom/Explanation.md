# Code Explanation ([Problem]())

```csharp
private readonly Random _random = new();
```

- This line declares a private field `_random` of type `Random`. The `Random` class is used to generate random numbers. Here, a new instance of `Random` is created using the default constructor. This instance will be used for generating random indices later.

```csharp
private readonly HashSet<int> _set = new();
```

- This line declares a private field `_set` of type `HashSet<int>`. A `HashSet` is a collection that does not allow duplicate elements. In this case, it's used to store a set of integers.

```csharp
public bool Insert(int val)
{
    return _set.Add(val);
}
```

- This method `Insert` takes an integer `val` as a parameter and attempts to add it to the `_set`. If the value is not already present in the set, it is added, and the method returns `true` to indicate a successful insertion. If the value is already in the set, it won't be added again, and the method returns `false`.

```csharp
public bool Remove(int val)
{
    return _set.Remove(val);
}
```

- This method `Remove` takes an integer `val` as a parameter and attempts to remove it from the `_set`. If the value is found and removed, the method returns `true`. If the value is not in the set, it returns `false`.

```csharp
public int GetRandom()
{
    var index = _random.Next(0, _set.Count);
    return _set.ElementAt(index);
}
```

- This method `GetRandom` generates a random index between 0 (inclusive) and the count of elements in the `_set` (exclusive) using the `_random.Next` method. It then uses this random index to select an element from the set using `ElementAt(index)`. This effectively retrieves a random element from the set and returns it as an integer.
