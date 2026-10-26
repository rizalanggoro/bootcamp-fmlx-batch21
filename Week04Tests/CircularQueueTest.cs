using Week04CircularQueue;

namespace Week04Tests;

public class CircularQueueTest
{
    [Fact]
    public void Log_Default_Capacity_And_Overwrite()
    {
        var q = new MyCircularQueue();
        Assert.Equal("Logged 1", q.Log(1));
        Assert.Equal("Logged 2", q.Log(2));
        Assert.Equal("Warning: Buffer at 66%\nLogged 3", q.Log(3));
        Assert.Equal("Critical: Buffer Full\nOverwritten oldest with 4", q.Log(4));
        Assert.Equal(3, q.Count);
        Assert.Equal("Read 2", q.Read());
        Assert.Equal("Read 3", q.Read());
        Assert.Equal("Read 4", q.Read());
        Assert.Equal("Buffer Empty", q.Read());
    }

    [Fact]
    public void SetCapacity_Changes_Buffer_Size()
    {
        var q = new MyCircularQueue();
        q.SetCapacity(5);

        Assert.Equal("Logged 1", q.Log(1));
        Assert.Equal("Logged 2", q.Log(2));
        Assert.Equal("Logged 3", q.Log(3));
        Assert.Equal("Logged 4", q.Log(4));
        Assert.Equal("Warning: Buffer at 66%\nLogged 5", q.Log(5));
        Assert.Equal("Critical: Buffer Full\nOverwritten oldest with 6", q.Log(6));
        Assert.Equal(5, q.Count);
        Assert.Equal("Read 2", q.Read());
    }

    [Fact]
    public void SetCapacity_Resets_Data()
    {
        var q = new MyCircularQueue();
        q.Log(1);
        q.Log(2);

        q.SetCapacity(2);

        Assert.Equal(0, q.Count);
        Assert.Equal("Buffer Empty", q.Read());
        Assert.Equal("Logged 9", q.Log(9));
        Assert.Equal(1, q.Count);
    }

    [Fact]
    public void SetOverwritePolicy_False_Rejects_When_Full()
    {
        var q = new MyCircularQueue();
        q.SetOverwritePolicy(false);

        Assert.Equal("Logged 1", q.Log(1));
        Assert.Equal("Logged 2", q.Log(2));
        Assert.Equal("Warning: Buffer at 66%\nLogged 3", q.Log(3));
        Assert.Equal("Critical: Buffer Full\nRejected 4", q.Log(4));
        Assert.Equal(3, q.Count);
        Assert.Equal("Read 1", q.Read());
        Assert.Equal("Read 2", q.Read());
        Assert.Equal("Read 3", q.Read());
    }

    [Fact]
    public void SetOverwritePolicy_True_Overwrites_Oldest()
    {
        var q = new MyCircularQueue();
        q.SetOverwritePolicy(false);
        q.Log(1);
        q.Log(2);
        q.Log(3);

        q.SetOverwritePolicy(true);

        Assert.Equal("Critical: Buffer Full\nOverwritten oldest with 4", q.Log(4));
        Assert.Equal(3, q.Count);
        Assert.Equal("Read 2", q.Read());
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void SetCapacity_Rejects_Non_Positive(int capacity)
    {
        var q = new MyCircularQueue();
        Assert.Throws<ArgumentOutOfRangeException>(() => q.SetCapacity(capacity));
    }

    [Fact]
    public void Read_Empty()
    {
        var q = new MyCircularQueue();
        Assert.Equal(0, q.Count);
        Assert.Equal("Buffer Empty", q.Read());
    }
}
