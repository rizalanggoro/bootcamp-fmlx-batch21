namespace MyLib;

public class MyQueue
{
    private string[] _items = [];

    public void Enqueue(string val)
    {
        Array.Resize(ref _items, _items.Length + 1);
        _items[_items.Length - 1] = val;
        Console.WriteLine($"Queued {val}");
    }

    public void Process()
    {
        if (_items.Length == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        string val = _items[0];

        for (int i = 0; i < _items.Length - 1; i++)
        {
            _items[i] = _items[i + 1];
        }
        Array.Resize(ref _items, _items.Length - 1);

        Console.WriteLine($"Processed {val}");
    }
}
