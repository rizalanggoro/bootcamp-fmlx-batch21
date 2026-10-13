namespace Week02CircularQueue;

public interface IMyCircularQueue
{
    int Count { get; }
    string Log(int num);
    string Read();
}
