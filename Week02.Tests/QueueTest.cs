using Week02Queue;

namespace Week02.Tests;

public class QueueTest
{
    [Fact]
    public void Enqueue_Normal()
    {
        var q = new MyQueue();
        Assert.Equal("Queued A", q.Enqueue("A"));
        Assert.Equal("Queued B", q.Enqueue("B"));
        Assert.Equal(2, q.Count);
        Assert.Equal(["A", "B"], q.GetQueue());
    }

    [Fact]
    public void Enqueue_Vip()
    {
        var q = new MyQueue();
        Assert.Equal("VIP Queued A", q.EnqueueVip("A"));
        Assert.Equal("VIP Queued B", q.EnqueueVip("B"));
        Assert.Equal(2, q.Count);
        Assert.Equal(["A", "B"], q.GetQueue());
    }

    [Fact]
    public void Enqueue_Combine()
    {
        var q = new MyQueue();
        Assert.Equal("Queued A", q.Enqueue("A"));
        Assert.Equal("Queued B", q.Enqueue("B"));
        Assert.Equal("VIP Queued C", q.EnqueueVip("C"));
        Assert.Equal("Queued D", q.Enqueue("D"));
        Assert.Equal("VIP Queued E", q.EnqueueVip("E"));
        Assert.Equal(5, q.Count);
        Assert.Equal(["C", "E", "A", "B", "D"], q.GetQueue());
    }

    [Fact]
    public void Process_Normal()
    {
        var q = new MyQueue();
        q.Enqueue("A");
        q.Enqueue("B");
        Assert.Equal(2, q.Count);

        Assert.Equal("Processed A", q.Process());
        Assert.Equal("Processed B", q.Process());
        Assert.Equal(0, q.Count);
    }

    [Fact]
    public void Process_Vip()
    {
        var q = new MyQueue();
        q.EnqueueVip("A");
        q.EnqueueVip("B");
        Assert.Equal(2, q.Count);

        Assert.Equal("Processed A", q.Process());
        Assert.Equal("Processed B", q.Process());
        Assert.Equal(0, q.Count);
    }

    [Fact]
    public void Process_Combine()
    {
        var q = new MyQueue();
        q.Enqueue("A");
        q.Enqueue("B");
        q.EnqueueVip("C");
        q.Enqueue("D");
        q.EnqueueVip("E");
        Assert.Equal(5, q.Count);

        var expectedQueue = new[] { "C", "E", "A", "B", "D" };
        Assert.Equal(expectedQueue, q.GetQueue());

        foreach (var item in expectedQueue)
            Assert.Equal($"Processed {item}", q.Process());
    }

    [Fact]
    public void Process_Empty()
    {
        var q = new MyQueue();
        Assert.Equal(0, q.Count);
        Assert.Equal("Queue is empty!", q.Process());
    }
}