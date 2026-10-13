namespace Week02LinkedList;

public class MyLinkedList : IMyLinkedList
{
    private Node? _head;
    private Node? _tail;

    public int Count { get; private set; }

    public string Append(int data)
    {
        var newNode = new Node(data);

        if (_head == null)
        {
            _head = newNode;
        }
        else
        {
            newNode.Previous = _tail;
            _tail!.Next = newNode;
        }

        _tail = newNode;
        Count++;

        return $"Appended {data}";
    }

    public string Print()
    {
        if (_head == null)
            return "Linked list is empty!";

        var values = new List<int>();
        var current = _head;
        while (current != null)
        {
            values.Add(current.Data);
            current = current.Next;
        }

        return $"Sequence: {string.Join(" -> ", values)}";
    }

    public string PrintReverse()
    {
        if (_tail == null)
            return "Linked list is empty!";

        var values = new List<int>();
        var current = _tail;
        while (current != null)
        {
            values.Add(current.Data);
            current = current.Previous;
        }

        return $"Reversed: {string.Join(" -> ", values)}";
    }
}