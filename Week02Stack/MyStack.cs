namespace Week02Stack;

public class MyStack : IMyStack
{
    private const int MaxStackSize = 3;
    private readonly List<string> _myStack = new();

    public string Type(string data)
    {
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

        return $"Undid {data}";
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