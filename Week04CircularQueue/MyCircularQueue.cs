namespace Week04CircularQueue;

public class MyCircularQueue : IMyCircularQueue
{
    private const int DefaultCapacity = 3;
    private const int PercentScale = 100;
    private const int WarningPercent = 66;

    private int[] _buffer = new int[DefaultCapacity];
    private int _capacity = DefaultCapacity;
    private bool _isOverwriteEnabled = true;
    private int _head;
    private int _count;

    public int Count => _count;

    public void SetCapacity(int n)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(n);

        _capacity = n;
        _buffer = new int[n];
        _head = 0;
        _count = 0;
    }

    public void SetOverwritePolicy(bool isOverwriteEnabled)
    {
        _isOverwriteEnabled = isOverwriteEnabled;
    }

    public string Log(int num)
    {
        var alert = GetAlert();

        if (_count == _capacity && !_isOverwriteEnabled)
            return Join(alert, $"Rejected {num}");

        string action;
        if (_count == _capacity)
        {
            _buffer[_head] = num;
            _head = (_head + 1) % _capacity;
            action = $"Overwritten oldest with {num}";
        }
        else
        {
            _buffer[(_head + _count) % _capacity] = num;
            _count++;
            action = $"Logged {num}";
        }

        return Join(alert, action);
    }

    public string Read()
    {
        if (_count == 0)
            return "Buffer Empty";

        var num = _buffer[_head];
        _head = (_head + 1) % _capacity;
        _count--;
        return $"Read {num}";
    }

    private string GetAlert()
    {
        if (_count * PercentScale >= PercentScale * _capacity)
            return "Critical: Buffer Full";

        if (_count * PercentScale >= WarningPercent * _capacity)
            return $"Warning: Buffer at {WarningPercent}%";

        return "";
    }

    private static string Join(string alert, string action)
    {
        return alert.Length == 0 ? action : $"{alert}\n{action}";
    }
}
