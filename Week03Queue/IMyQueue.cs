namespace Week03Queue;

public interface IMyQueue
{
    int Count { get; }
    string Enqueue(string data, int priority);
    string Process();
}
