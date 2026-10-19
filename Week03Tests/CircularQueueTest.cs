using Week03CircularQueue;

namespace Week03Tests;

public class CircularQueueTest
{
    [Fact]
    public void Log_Sample()
    {
        var q = new MyCircularQueue();
        Assert.Equal("Logged 1", q.Log(1));
        Assert.Equal("Logged 2", q.Log(2));
        Assert.Equal("Warning: Buffer at 66%\nLogged 3", q.Log(3));
        Assert.Equal("Critical: Buffer Full\nOverwritten oldest with 4", q.Log(4));
        Assert.Equal(3, q.Count);
        Assert.Equal("Read 2", q.Read());
    }

    [Fact]
    public void Log_Below_Warning_Threshold()
    {
        var q = new MyCircularQueue();
        Assert.Equal("Logged 1", q.Log(1));
        Assert.Equal("Logged 2", q.Log(2));
        Assert.Equal(2, q.Count);
    }

    [Fact]
    public void Log_Warning_When_Two_Of_Three_Unread()
    {
        var q = new MyCircularQueue();
        q.Log(1);
        q.Log(2);
        Assert.Equal("Warning: Buffer at 66%\nLogged 3", q.Log(3));
        Assert.Equal(3, q.Count);
    }

    [Fact]
    public void Log_Critical_Only_When_Full()
    {
        var q = new MyCircularQueue();
        q.Log(1);
        q.Log(2);
        q.Log(3);
        Assert.Equal("Critical: Buffer Full\nOverwritten oldest with 4", q.Log(4));
        Assert.Equal(3, q.Count);
        Assert.Equal("Read 2", q.Read());
        Assert.Equal("Read 3", q.Read());
        Assert.Equal("Read 4", q.Read());
    }

    [Fact]
    public void Log_Warning_After_Read()
    {
        var q = new MyCircularQueue();
        q.Log(1);
        q.Log(2);
        q.Log(3);
        Assert.Equal("Read 1", q.Read());
        Assert.Equal("Warning: Buffer at 66%\nLogged 4", q.Log(4));
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
