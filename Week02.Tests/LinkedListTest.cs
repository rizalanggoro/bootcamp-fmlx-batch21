using Week02LinkedList;

namespace Week02.Tests;

public class LinkedListTest
{
    [Fact]
    public void Append()
    {
        var list = new MyLinkedList();
        Assert.Equal("Appended 5", list.Append(5));
        Assert.Equal("Appended 10", list.Append(10));
        Assert.Equal("Appended 15", list.Append(15));
        Assert.Equal(3, list.Count);
        Assert.Equal("Sequence: 5 -> 10 -> 15", list.Print());
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
        list.Append(5);
        list.Append(10);
        list.Append(15);
        Assert.Equal("Reversed: 15 -> 10 -> 5", list.PrintReverse());
    }

    [Fact]
    public void PrintReverse_Single()
    {
        var list = new MyLinkedList();
        list.Append(5);
        Assert.Equal("Reversed: 5", list.PrintReverse());
    }

    [Fact]
    public void PrintReverse_Empty()
    {
        var list = new MyLinkedList();
        Assert.Equal("Linked list is empty!", list.PrintReverse());
    }
}
