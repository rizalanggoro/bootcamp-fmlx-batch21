namespace Week03CircularQueue;

public class MyCircularQueue : IMyCircularQueue
{
    private const int MaxBufferSize = 3;
    private const int PercentScale = 100;
    private const int WarningPercent = 66;
    private const int FullPercent = 100;

    private readonly int[] _buffer = new int[MaxBufferSize];
    private int _head;
    private int _count;

    public int Count => _count;

    public string Log(int num)
    {
        var alert = GetAlert();

        string action;
        if (_count == MaxBufferSize)
        {
            _buffer[_head] = num;
            _head = (_head + 1) % MaxBufferSize;
            action = $"Overwritten oldest with {num}";
        }
        else
        {
            _buffer[(_head + _count) % MaxBufferSize] = num;
            _count++;
            action = $"Logged {num}";
        }

        return alert.Length == 0 ? action : $"{alert}\n{action}";
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

    private string GetAlert()
    {
        if (_count * PercentScale >= FullPercent * MaxBufferSize)
            return "Critical: Buffer Full";

        if (_count * PercentScale >= WarningPercent * MaxBufferSize)
            return $"Warning: Buffer at {WarningPercent}%";

        return "";
    }
}
