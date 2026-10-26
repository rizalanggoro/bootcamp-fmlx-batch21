using Week04Queue;

namespace Week04Tests;

public class QueueTest
{
    private static MyQueue Create()
    {
        var queue = new MyQueue();
        queue.AddRule("urgent", 10);
        queue.AddRule("normal", 5);
        return queue;
    }

    [Fact]
    public void Enqueue_Sample()
    {
        var queue = Create();
        Assert.Equal("Queued normal with priority 5", queue.Enqueue("normal"));
        Assert.Equal("Queued urgent with priority 10", queue.Enqueue("urgent"));
        Assert.Equal(2, queue.Count);
    }

    [Fact]
    public void Enqueue_Default_Priority_When_No_Rule_Matches()
    {
        Assert.Equal("Queued low with priority 0", Create().Enqueue("low"));
    }

    [Fact]
    public void Enqueue_Matches_Keyword_Inside_Text()
    {
        Assert.Equal("Queued this is urgent with priority 10", Create().Enqueue("this is urgent"));
    }

    [Fact]
    public void Enqueue_Matches_Keyword_Case_Insensitive()
    {
        Assert.Equal("Queued URGENT with priority 10", Create().Enqueue("URGENT"));
    }

    [Fact]
    public void Enqueue_Uses_First_Matching_Rule()
    {
        var queue = new MyQueue();
        queue.AddRule("normal", 5);
        queue.AddRule("urgent", 10);

        Assert.Equal("Queued urgent normal with priority 5", queue.Enqueue("urgent normal"));
    }

    [Fact]
    public void Process_Highest_Priority_First()
    {
        var queue = Create();
        queue.Enqueue("normal");
        queue.Enqueue("low");
        queue.Enqueue("urgent");

        Assert.Equal("Processed urgent", queue.Process());
        Assert.Equal("Processed normal", queue.Process());
        Assert.Equal("Processed low", queue.Process());
        Assert.Equal(0, queue.Count);
    }

    [Fact]
    public void Process_Same_Priority_Fifo()
    {
        var queue = Create();
        queue.Enqueue("normal A");
        queue.Enqueue("normal B");

        Assert.Equal("Processed normal A", queue.Process());
        Assert.Equal("Processed normal B", queue.Process());
    }

    [Fact]
    public void Process_Empty()
    {
        Assert.Equal("Queue is empty!", new MyQueue().Process());
    }
}
