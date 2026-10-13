namespace Week03Queue;

public class MyQueue : IMyQueue
{
    private readonly List<QueueItem> _queue = new();

    public int Count => _queue.Count;

    public string Enqueue(string data, int priority)
    {
        _queue.Add(new QueueItem { Data = data, Priority = priority });
        return $"Queued {data} with priority {priority}";
    }

    public string Process()
    {
        if (_queue.Count == 0)
            return "Queue is empty!";

        var index = 0;
        for (var i = 1; i < _queue.Count; i++)
            if (_queue[i].Priority > _queue[index].Priority)
                index = i;

        var item = _queue[index];
        _queue.RemoveAt(index);
        return $"Processed {item.Data}";
    }
}
