namespace Day3.Classes;

internal sealed class SingletonCounter
{
    private SingletonCounter()
    {
    }

    internal int CounterValue { get; private set; }

    internal static SingletonCounter Instance { get; } = new();

    internal void Increment()
    {
        CounterValue++;
    }
}