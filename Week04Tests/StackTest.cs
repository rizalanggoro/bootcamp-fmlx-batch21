using Week04Stack;

namespace Week04Tests;

public class StackTest
{
    private static MyStack Create()
    {
        var history = new MyStack();
        history.AddValidationRule(word => !string.IsNullOrWhiteSpace(word));
        history.AddValidationRule(word => word.Length <= 10);
        return history;
    }

    [Fact]
    public void Type_Sample()
    {
        var history = Create();
        Assert.Equal("Typed hello", history.Type("hello"));
        Assert.Equal("Rejected ", history.Type(""));
        Assert.Equal(["hello"], history.GetStack());
    }

    [Fact]
    public void Type_Rejects_Too_Long()
    {
        var history = Create();
        Assert.Equal("Rejected abcdefghijk", history.Type("abcdefghijk"));
        Assert.Equal(0, history.GetCount());
    }

    [Fact]
    public void Type_Rejects_Whitespace()
    {
        var history = Create();
        Assert.Equal("Rejected    ", history.Type("   "));
        Assert.Equal(0, history.GetCount());
    }

    [Fact]
    public void Type_All_Rules_Must_Pass()
    {
        var history = Create();
        Assert.Equal("Typed 1234567890", history.Type("1234567890"));
        Assert.Equal("Rejected 12345678901", history.Type("12345678901"));
    }

    [Fact]
    public void Type_Without_Rules_Accepts_Anything()
    {
        var history = new MyStack();
        Assert.Equal("Typed hello", history.Type("hello"));
        Assert.Equal("Typed ", history.Type(""));
    }

    [Fact]
    public void Type_Rejected_Keeps_Existing_History()
    {
        var history = Create();
        history.Type("A");
        history.Type("B");
        history.Type("C");

        Assert.Equal("Rejected ", history.Type(""));
        Assert.Equal(["A", "B", "C"], history.GetStack());
        Assert.Equal(3, history.GetCount());
    }

    [Fact]
    public void Type_Drops_Bottom_At_Max_Size()
    {
        var history = Create();
        history.Type("A");
        history.Type("B");
        history.Type("C");

        Assert.Equal("Dropped bottom, Typed D", history.Type("D"));
        Assert.Equal(["B", "C", "D"], history.GetStack());
    }

    [Fact]
    public void Undo_And_Redo()
    {
        var history = Create();
        history.Type("A");
        history.Type("B");

        Assert.Equal("Undid B", history.Undo());
        Assert.Equal("Redid B", history.Redo());
        Assert.Equal(["A", "B"], history.GetStack());
    }

    [Fact]
    public void Undo_Empty()
    {
        Assert.Equal("Stack is empty!", new MyStack().Undo());
    }

    [Fact]
    public void Redo_Empty()
    {
        Assert.Equal("Nothing to redo!", new MyStack().Redo());
    }
}
