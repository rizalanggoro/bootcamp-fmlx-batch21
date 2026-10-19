namespace Week03Stack;

public class MyStack : IMyStack
{
    private const int MaxStackSize = 3;
    private readonly List<string> _myStack = new();
    private readonly Stack<string> _redo = new();

    public string Type(string data)
    {
        _redo.Clear();

        var message = "";
        if (_myStack.Count >= MaxStackSize)
        {
            _myStack.RemoveAt(0);
            message += "Dropped bottom, ";
        }

        _myStack.Add(data);
        message += $"Typed {data}";

        return message;
    }

    public string Undo()
    {
        if (_myStack.Count == 0)
            return "Stack is empty!";

        var data = _myStack[^1];
        _myStack.RemoveAt(_myStack.Count - 1);
        _redo.Push(data);

        return $"Undid {data}";
    }

    public string Redo()
    {
        if (_redo.Count == 0)
            return "Nothing to redo!";

        var data = _redo.Pop();
        _myStack.Add(data);

        return $"Redid {data}";
    }

    public string[] GetStack()
    {
        return _myStack.ToArray();
    }

    public int GetCount()
    {
        return _myStack.Count;
    }
}
