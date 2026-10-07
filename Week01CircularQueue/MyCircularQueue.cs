namespace Week01CircularQueue;

internal class MyCircularQueue
{
    private const int MaxBufferSize = 3;

    private readonly int[] _buffer = new int[MaxBufferSize];
    private int _bufferCount;

    internal void Log(int num)
    {
        if (_bufferCount == MaxBufferSize)
        {
            Console.WriteLine("Buffer Full");
            return;
        }

        Console.WriteLine($"Logged {num}");
        _buffer[_bufferCount] = num;
        _bufferCount++;
    }

    internal void Read()
    {
        if (_bufferCount == 0)
        {
            Console.WriteLine("Buffer Empty");
            return;
        }

        Console.WriteLine($"Read {_buffer[0]}");

        for (var i = 0; i < _bufferCount - 1; i++)
            _buffer[i] = _buffer[i + 1];

        _bufferCount--;
    }

    internal void Print()
    {
        Console.Write("Buffer: ");

        for (var i = 0; i < _bufferCount; i++)
        {
            Console.Write(_buffer[i]);
            if (i < _bufferCount - 1)
                Console.Write(", ");
        }

        Console.WriteLine();
    }
}