using Week02Stack;

namespace Week02.Tests;

public class StackTest
{
    [Fact]
    public void Type()
    {
        var myStack = new MyStack();
        Assert.Equal("Typed A", myStack.Type("A"));
        Assert.Equal("Typed B", myStack.Type("B"));
        Assert.Equal("Typed C", myStack.Type("C"));
        Assert.Equal(["A", "B", "C"], myStack.GetStack());
        Assert.Equal(3, myStack.GetCount());
    }

    [Fact]
    public void Type_DroppedBottom()
    {
        var myStack = new MyStack();
        Assert.Equal("Typed A", myStack.Type("A"));
        Assert.Equal("Typed B", myStack.Type("B"));
        Assert.Equal("Typed C", myStack.Type("C"));
        Assert.Equal("Dropped bottom, Typed D", myStack.Type("D"));
        Assert.Equal(3, myStack.GetCount());
        Assert.Equal(["B", "C", "D"], myStack.GetStack());
    }

    [Fact]
    public void Undo()
    {
        var myStack = new MyStack();
        Assert.Equal("Typed A", myStack.Type("A"));
        Assert.Equal("Typed B", myStack.Type("B"));
        Assert.Equal("Typed C", myStack.Type("C"));
        Assert.Equal(["A", "B", "C"], myStack.GetStack());
        Assert.Equal(3, myStack.GetCount());

        Assert.Equal("Undid C", myStack.Undo());
        Assert.Equal("Undid B", myStack.Undo());
        Assert.Equal("Undid A", myStack.Undo());
        Assert.Equal(0, myStack.GetCount());
    }

    [Fact]
    public void Undo_Empty()
    {
        var myStack = new MyStack();
        Assert.Equal(0, myStack.GetCount());
        Assert.Equal("Stack is empty!", myStack.Undo());
    }
}