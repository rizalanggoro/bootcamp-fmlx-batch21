namespace Week01Queue;

public class MyQueue
{
    private readonly string[] _data = new string[32];
    private int _count;

    public void Enqueue(string val)
    {
        if (_count == _data.Length)
        {
            Console.WriteLine("Queue is full");
            return;
        }

        _data[_count] = val;
        _count++;
        Console.WriteLine($"Queued {val}");
    }

    public void Process()
    {
        if (_count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        var val = _data[0];
        for (var i = 1; i < _count; i++)
            _data[i - 1] = _data[i];

        _count--;
        Console.WriteLine($"Processed {val}");
    }
}