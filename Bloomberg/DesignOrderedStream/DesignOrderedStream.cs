namespace Leetcode.Bloomberg.DesignOrderedStream;

public class DesignOrderedStream
{
    private readonly PriorityQueue<string, int> _minHeap;
    private int _pointer = 1;
    public DesignOrderedStream(int n)
    {
        _minHeap = new PriorityQueue<string, int>(n);
    }

    public IList<string> Insert(int idKey, string value)
    {
        _minHeap.Enqueue(value, idKey);
        _minHeap.TryPeek(out var _, out var index);
        
        var result = new List<string>();
        while (index == _pointer)
        {
           result.Add(_minHeap.Dequeue());
           _pointer++;
           _minHeap.TryPeek(out var _, out index);
        }

        return result;
    }
}