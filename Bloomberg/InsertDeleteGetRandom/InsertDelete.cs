namespace Leetcode.Bloomberg.InsertDeleteGetRandom;

public class InsertDelete
{
    private readonly Random _random = new();
    private readonly HashSet<int> _set = new();

    public bool Insert(int val)
    {
        return _set.Add(val);
    }

    public bool Remove(int val)
    {
        return _set.Remove(val);
    }

    public int GetRandom()
    {
        var index = _random.Next(0, _set.Count);
        return _set.ElementAt(index);
    }
}