namespace Week04Queue;

public class MyQueue : IMyQueue
{
    private readonly List<QueueItem> _queue = new();
    private readonly List<QueueRule> _rules = new();

    public int Count => _queue.Count;

    public void AddRule(string keyword, int priority)
    {
        _rules.Add(new QueueRule(keyword, priority));
    }

    public string Enqueue(string val)
    {
        var priority = _rules
            .FirstOrDefault(rule => val.Contains(rule.Keyword, StringComparison.OrdinalIgnoreCase))
            ?.Priority ?? 0;

        _queue.Add(
            new QueueItem
            {
                Data = val,
                Priority = priority
            }
        );

        return $"Queued {val} with priority {priority}";
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