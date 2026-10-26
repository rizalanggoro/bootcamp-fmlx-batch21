namespace Week04Stack;

public class MyStack : IMyStack
{
    private const int MaxStackSize = 3;
    private readonly List<string> _myStack = new();
    private readonly Stack<string> _redo = new();
    private readonly List<Func<string, bool>> _validationRules = new();

    public void AddValidationRule(Func<string, bool> rule)
    {
        _validationRules.Add(rule);
    }

    public string Type(string word)
    {
        if (!_validationRules.All(rule => rule(word)))
            return $"Rejected {word}";

        _redo.Clear();

        var message = "";
        if (_myStack.Count >= MaxStackSize)
        {
            _myStack.RemoveAt(0);
            message += "Dropped bottom, ";
        }

        _myStack.Add(word);
        message += $"Typed {word}";

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
