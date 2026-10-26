using Week04LinkedList;

namespace Week04Tests;

public class LinkedListTest
{
    private static MyLinkedList Create()
    {
        var list = new MyLinkedList();
        list.Append(5);
        list.Append(2);
        list.Append(8);
        list.Append(4);
        return list;
    }

    [Fact]
    public void Append_Keeps_Insertion_Order()
    {
        Assert.Equal("Sequence: 5 -> 2 -> 8 -> 4", Create().Print());
    }

    [Fact]
    public void Append_Message()
    {
        Assert.Equal("Appended 5", new MyLinkedList().Append(5));
    }

    [Fact]
    public void Append_Count()
    {
        Assert.Equal(4, Create().Count);
    }

    [Fact]
    public void SetSorting_Ascending()
    {
        var list = Create();
        list.SetSorting((a, b) => a.CompareTo(b));

        Assert.Equal("Sequence: 2 -> 4 -> 5 -> 8", list.Print());
    }

    [Fact]
    public void SetSorting_Descending()
    {
        var list = Create();
        list.SetSorting((a, b) => b.CompareTo(a));

        Assert.Equal("Sequence: 8 -> 5 -> 4 -> 2", list.Print());
    }

    [Fact]
    public void AddFilter_Hides_Non_Matching()
    {
        var list = Create();
        list.AddFilter(value => value % 2 == 0);

        Assert.Equal("Sequence: 2 -> 8 -> 4", list.Print());
    }

    [Fact]
    public void AddFilter_All_Must_Pass()
    {
        var list = Create();
        list.AddFilter(value => value % 2 == 0);
        list.AddFilter(value => value > 2);

        Assert.Equal("Sequence: 8 -> 4", list.Print());
    }

    [Fact]
    public void AddFilter_Applies_Before_Sorting()
    {
        var list = Create();
        list.AddFilter(value => value % 2 == 0);
        list.SetSorting((a, b) => a.CompareTo(b));

        Assert.Equal("Sequence: 2 -> 4 -> 8", list.Print());
    }

    [Fact]
    public void AddFilter_That_Removes_All_Shows_Empty()
    {
        var list = Create();
        list.AddFilter(value => value > 100);

        Assert.Equal("Linked list is empty!", list.Print());
    }

    [Fact]
    public void Print_Empty()
    {
        Assert.Equal("Linked list is empty!", new MyLinkedList().Print());
    }
}
