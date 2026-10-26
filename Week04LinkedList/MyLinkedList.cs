namespace Week04LinkedList;

public class MyLinkedList : IMyLinkedList
{
    private readonly List<Func<int, bool>> _filters = new();
    private Node? _head;
    private Node? _tail;
    private Func<int, int, int>? _comparer;

    public int Count { get; private set; }

    public string Append(int val)
    {
        var newNode = new Node(val);

        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail!.Next = newNode;
            _tail = newNode;
        }

        Count++;

        return $"Appended {val}";
    }

    public void SetSorting(Func<int, int, int> comparer)
    {
        _comparer = comparer;
    }

    public void AddFilter(Func<int, bool> filterRule)
    {
        _filters.Add(filterRule);
    }

    public string Print()
    {
        var values = new List<int>();
        for (var current = _head; current != null; current = current.Next)
            if (_filters.All(filter => filter(current.Data)))
                values.Add(current.Data);

        if (values.Count == 0)
            return "Linked list is empty!";

        var comparer = _comparer;
        if (comparer != null)
            values.Sort(comparer.Invoke);

        return $"Sequence: {string.Join(" -> ", values)}";
    }
}
