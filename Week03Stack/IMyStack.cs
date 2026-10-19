namespace Week03Stack;

public interface IMyStack
{
    string Type(string data);
    string Undo();
    string Redo();

    string[] GetStack();
    int GetCount();
}
