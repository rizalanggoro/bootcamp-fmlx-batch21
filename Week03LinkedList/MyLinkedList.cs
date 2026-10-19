namespace Week03LinkedList;

public class MyLinkedList : IMyLinkedList
{
    private Node? _head;
    private Node? _tail;

    public int Count { get; private set; }

    public string Insert(int data)
    {
        var newNode = new Node(data);

        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else if (data < _head.Data)
        {
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
        }
        else
        {
            var current = _head;
            while (current.Next != null && current.Next.Data <= data)
                current = current.Next;

            newNode.Previous = current;
            newNode.Next = current.Next;

            if (current.Next == null)
                _tail = newNode;
            else
                current.Next.Previous = newNode;

            current.Next = newNode;
        }

        Count++;

        return $"Inserted {data}";
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
