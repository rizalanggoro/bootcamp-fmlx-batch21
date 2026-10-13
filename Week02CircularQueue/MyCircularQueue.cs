namespace Week02CircularQueue;

public class MyCircularQueue : IMyCircularQueue
{
    private const int MaxBufferSize = 3;

    private readonly int[] _buffer = new int[MaxBufferSize];
    private int _head;
    private int _count;

    public int Count => _count;

    public string Log(int num)
    {
        if (_count == MaxBufferSize)
        {
            _buffer[_head] = num;
            _head = (_head + 1) % MaxBufferSize;
            return $"Overwritten oldest with {num}";
        }

        _buffer[(_head + _count) % MaxBufferSize] = num;
        _count++;
        return $"Logged {num}";
    }

    public string Read()
    {
        if (_count == 0)
            return "Buffer Empty";

        var num = _buffer[_head];
        _head = (_head + 1) % MaxBufferSize;
        _count--;
        return $"Read {num}";
    }
}
