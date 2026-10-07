namespace Week01Stack.Lib;

internal class FixedTypingHistory : ITypingHistory
{
    private const int MaxHistorySize = 100;
    private readonly string[] _data = new string[MaxHistorySize];

    private int _count;

    public void Type(string word)
    {
        if (_count == MaxHistorySize)
        {
            Console.WriteLine("Stack is full");
            return;
        }

        _data[_count] = word;
        _count++;

        Console.WriteLine($"Typed {word}");
    }

    public void Undo()
    {
        if (_count == 0)
        {
            Console.WriteLine("Stack is empty");
            return;
        }

        _count--;

        Console.WriteLine($"Undid {_data[_count]}");
    }
}