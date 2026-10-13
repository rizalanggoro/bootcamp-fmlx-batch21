using Week03Queue;

namespace Week03Tests;

public class QueueTest
{
    [Fact]
    public void Enqueue()
    {
        var q = new MyQueue();
        Assert.Equal("Queued A with priority 1", q.Enqueue("A", 1));
        Assert.Equal("Queued B with priority 5", q.Enqueue("B", 5));
        Assert.Equal(2, q.Count);
    }

    [Fact]
    public void Process_Highest_Priority_First()
    {
        var q = new MyQueue();
        q.Enqueue("A", 1);
        q.Enqueue("B", 5);
        q.Enqueue("C", 5);
        Assert.Equal("Processed B", q.Process());
        Assert.Equal("Processed C", q.Process());
        Assert.Equal("Processed A", q.Process());
        Assert.Equal(0, q.Count);
    }

    [Fact]
    public void Process_Low_Priority_First_In_Line()
    {
        var q = new MyQueue();
        q.Enqueue("A", 1);
        q.Enqueue("B", 2);
        Assert.Equal("Processed B", q.Process());
        Assert.Equal("Queued C with priority 9", q.Enqueue("C", 9));
        Assert.Equal("Processed C", q.Process());
        Assert.Equal("Processed A", q.Process());
    }

    [Fact]
    public void Process_Same_Priority_Fifo()
    {
        var q = new MyQueue();
        q.Enqueue("A", 3);
        q.Enqueue("B", 3);
        q.Enqueue("C", 3);
        Assert.Equal("Processed A", q.Process());
        Assert.Equal("Processed B", q.Process());
        Assert.Equal("Processed C", q.Process());
    }

    [Fact]
    public void Process_Empty()
    {
        var q = new MyQueue();
        Assert.Equal("Queue is empty!", q.Process());
    }
}
