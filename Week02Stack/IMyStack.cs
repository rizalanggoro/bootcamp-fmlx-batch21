namespace Week02Stack;

public interface IMyStack
{
    string Type(string data);
    string Undo();

    string[] GetStack();
    int GetCount();
}