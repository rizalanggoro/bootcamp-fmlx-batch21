namespace Week02Queue;

public class MyQueue : IMyQueue
{
    private readonly List<QueueItem> _queue = new();

    public int Count => _queue.Count;

    public string Enqueue(string data)
    {
        _queue.Add(
            new QueueItem
            {
                Data = data,
                IsVip = false
            }
        );

        return $"Queued {data}";
    }

    public string EnqueueVip(string data)
    {
        if (_queue.Count == 0)
        {
            _queue.Add(new QueueItem
                {
                    Data = data,
                    IsVip = true
                }
            );
        }
        else
        {
            var insertIndex = _queue.First().IsVip
                ? _queue.FindLastIndex(it => it.IsVip) + 1
                : _queue.FindIndex(it => !it.IsVip);

            _queue.Insert(
                insertIndex,
                new QueueItem
                {
                    Data = data,
                    IsVip = true
                }
            );
        }

        return $"VIP Queued {data}";
    }

    public string Process()
    {
        if (_queue.Count == 0)
            return "Queue is empty!";

        var item = _queue.First();
        _queue.RemoveAt(0);

        return $"Processed {item.Data}";
    }

    public string[] GetQueue()
    {
        return _queue.Select(x => x.Data).ToArray();
    }
}