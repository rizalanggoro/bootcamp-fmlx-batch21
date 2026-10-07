namespace Week01Stack.Lib;

public class CollectionTypingHistory : ITypingHistory
{
    private readonly Stack<string> _stack = [];

    public void Type(string word)
    {
        _stack.Push(word);
        Console.WriteLine($"Typed {word}");
    }

    public void Undo()
    {
        if (_stack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
            return;
        }

        Console.WriteLine($"Undid {_stack.Pop()}");
    }
}