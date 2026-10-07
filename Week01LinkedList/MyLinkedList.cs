namespace Week01LinkedList;

internal class MyLinkedList
{
    private Node? _head;
    private Node? _tail;

    internal void Append(int num)
    {
        if (_head == null && _tail == null)
        {
            var newNode = new Node(num);
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            var newNode = new Node(num)
            {
                NextNode = null
            };

            if (_tail != null)
                _tail.NextNode = newNode;
            _tail = newNode;
        }

        Console.WriteLine($"Appended {num}");
    }

    internal void Print()
    {
        if (_head == null)
        {
            Console.WriteLine("Linked list is empty!");
            return;
        }

        Console.Write("Sequence: ");

        var currentNode = _head;
        while (currentNode != null)
        {
            Console.Write(currentNode.Num);
            currentNode = currentNode.NextNode;

            if (currentNode != null)
                Console.Write(" -> ");
            else
                Console.WriteLine();
        }
    }

    internal class Node(int num)
    {
        internal readonly int Num = num;
        internal Node? NextNode;
    }
}