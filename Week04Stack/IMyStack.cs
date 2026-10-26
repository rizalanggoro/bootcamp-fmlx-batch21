namespace Week04Stack;

public interface IMyStack
{
    void AddValidationRule(Func<string, bool> rule);
    string Type(string word);
    string Undo();
    string Redo();

    string[] GetStack();
    int GetCount();
}
