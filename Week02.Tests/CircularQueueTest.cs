using Week02CircularQueue;

namespace Week02.Tests;

public class CircularQueueTest
{
    [Fact]
    public void Log()
    {
        var q = new MyCircularQueue();
        Assert.Equal("Logged 1", q.Log(1));
        Assert.Equal("Logged 2", q.Log(2));
        Assert.Equal("Logged 3", q.Log(3));
        Assert.Equal(3, q.Count);
    }

    [Fact]
    public void Log_Full_Overwrites_Oldest()
    {
        var q = new MyCircularQueue();
        q.Log(1);
        q.Log(2);
        q.Log(3);
        Assert.Equal("Overwritten oldest with 4", q.Log(4));
        Assert.Equal(3, q.Count);

        Assert.Equal("Read 2", q.Read());
        Assert.Equal("Read 3", q.Read());
        Assert.Equal("Read 4", q.Read());
        Assert.Equal(0, q.Count);
    }

    [Fact]
    public void Log_Multiple_Overwrites()
    {
        var q = new MyCircularQueue();
        q.Log(1);
        q.Log(2);
        q.Log(3);
        q.Log(4);
        Assert.Equal("Overwritten oldest with 5", q.Log(5));

        Assert.Equal("Read 3", q.Read());
        Assert.Equal("Read 4", q.Read());
        Assert.Equal("Read 5", q.Read());
    }

    [Fact]
    public void Read_Wraps_Around()
    {
        var q = new MyCircularQueue();
        q.Log(1);
        q.Log(2);
        q.Log(3);

        Assert.Equal("Read 1", q.Read());
        Assert.Equal("Logged 4", q.Log(4));
        Assert.Equal("Read 2", q.Read());
        Assert.Equal("Read 3", q.Read());
        Assert.Equal("Read 4", q.Read());
    }

    [Fact]
    public void Read_Empty()
    {
        var q = new MyCircularQueue();
        Assert.Equal(0, q.Count);
        Assert.Equal("Buffer Empty", q.Read());
    }
}