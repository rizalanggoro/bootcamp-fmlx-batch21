namespace Week04LinkedList;

public interface IMyLinkedList
{
    int Count { get; }
    string Append(int val);
    void SetSorting(Func<int, int, int> comparer);
    void AddFilter(Func<int, bool> filterRule);
    string Print();
}
