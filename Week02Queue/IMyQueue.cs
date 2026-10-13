namespace Week02Queue;

public interface IMyQueue
{
    string Enqueue(string data);
    string EnqueueVip(string data);
    string Process();
}