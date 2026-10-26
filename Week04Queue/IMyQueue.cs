namespace Week04Queue;

public interface IMyQueue
{
    int Count { get; }
    void AddRule(string keyword, int priority);
    string Enqueue(string val);
    string Process();
}
