namespace Week01CircularQueue;

public class MyCircularQueueList : ICircularQueue
{
    private const int MaxBufferSize = 3;
    private readonly List<int> _buffer = new();

    public void Log(int num)
    {
        if (_buffer.Count >= MaxBufferSize)
        {
            Console.WriteLine("Buffer Full");
            return;
        }

        _buffer.Add(num);
        Console.WriteLine($"Logged {num}");
    }

    public void Read()
    {
        if (_buffer.Count == 0)
        {
            Console.WriteLine("Buffer Empty");
            return;
        }

        Console.WriteLine($"Read {_buffer.First()}");
        _buffer.RemoveAt(0);
    }

    public void Print()
    {
        Console.Write("Buffer: ");
        for (var i = 0; i < _buffer.Count; i++)
        {
            Console.Write(_buffer[i]);
            if (i < _buffer.Count - 1)
                Console.Write(", ");
        }

        Console.WriteLine();
    }
}