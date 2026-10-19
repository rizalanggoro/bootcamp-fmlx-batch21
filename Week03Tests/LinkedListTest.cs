using Week03LinkedList;

namespace Week03Tests;

public class LinkedListTest
{
    [Fact]
    public void Insert_Sorts_Ascending()
    {
        var list = new MyLinkedList();
        Assert.Equal("Inserted 5", list.Insert(5));
        Assert.Equal("Inserted 2", list.Insert(2));
        Assert.Equal("Inserted 8", list.Insert(8));
        Assert.Equal(3, list.Count);
        Assert.Equal("Sequence: 2 -> 5 -> 8", list.Print());
    }

    [Fact]
    public void Insert_At_Head()
    {
        var list = new MyLinkedList();
        list.Insert(5);
        list.Insert(2);
        Assert.Equal("Sequence: 2 -> 5", list.Print());
        Assert.Equal("Reversed: 5 -> 2", list.PrintReverse());
    }

    [Fact]
    public void Insert_At_Tail()
    {
        var list = new MyLinkedList();
        list.Insert(2);
        list.Insert(8);
        Assert.Equal("Sequence: 2 -> 8", list.Print());
        Assert.Equal("Reversed: 8 -> 2", list.PrintReverse());
    }

    [Fact]
    public void Insert_Between()
    {
        var list = new MyLinkedList();
        list.Insert(5);
        list.Insert(10);
        list.Insert(7);
        Assert.Equal("Sequence: 5 -> 7 -> 10", list.Print());
        Assert.Equal(3, list.Count);
    }

    [Fact]
    public void Insert_Duplicates_Keep_Order()
    {
        var list = new MyLinkedList();
        list.Insert(5);
        list.Insert(2);
        list.Insert(5);
        Assert.Equal("Sequence: 2 -> 5 -> 5", list.Print());
    }

    [Fact]
    public void Print_Empty()
    {
        var list = new MyLinkedList();
        Assert.Equal("Linked list is empty!", list.Print());
    }

    [Fact]
    public void PrintReverse()
    {
        var list = new MyLinkedList();
        list.Insert(5);
        list.Insert(10);
        list.Insert(15);
        Assert.Equal("Reversed: 15 -> 10 -> 5", list.PrintReverse());
    }

    [Fact]
    public void PrintReverse_Empty()
    {
        var list = new MyLinkedList();
        Assert.Equal("Linked list is empty!", list.PrintReverse());
    }
}
