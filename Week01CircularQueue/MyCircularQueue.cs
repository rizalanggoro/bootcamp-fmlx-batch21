namespace Week01CircularQueue;

internal class MyCircularQueue : ICircularQueue
{
    private const int MaxBufferSize = 3;

    private readonly int[] _buffer = new int[MaxBufferSize];
    private int _head;
    private int _count;

    public void Log(int num)
    {
        if (_count == MaxBufferSize)
        {
            Console.WriteLine("Buffer Full");
            return;
        }

        Console.WriteLine($"Logged {num}");
        _buffer[(_head + _count) % MaxBufferSize] = num;
        _count++;
    }

    public void Read()
    {
        if (_count == 0)
        {
            Console.WriteLine("Buffer Empty");
            return;
        }

        Console.WriteLine($"Read {_buffer[_head]}");
        _head = (_head + 1) % MaxBufferSize;
        _count--;
    }

    public void Print()
    {
        Console.Write("Buffer: ");

        for (var i = 0; i < _count; i++)
        {
            if (i > 0)
                Console.Write(", ");
            Console.Write(_buffer[(_head + i) % MaxBufferSize]);
        }

        Console.WriteLine();
    }
}
