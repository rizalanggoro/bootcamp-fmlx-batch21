namespace Week01Stack;

public class MyStack
{
    private int _count;
    private readonly string[] _data = new string[32];

    public void Type(string word)
    {
        if (_count == _data.Length)
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
        var word = _data[_count];
        Console.WriteLine($"Undid {word}");
    }
}