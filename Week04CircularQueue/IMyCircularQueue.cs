namespace Week04CircularQueue;

public interface IMyCircularQueue
{
    int Count { get; }
    void SetCapacity(int n);
    void SetOverwritePolicy(bool isOverwriteEnabled);
    string Log(int num);
    string Read();
}
