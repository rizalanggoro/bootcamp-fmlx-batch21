using Week03Stack;

namespace Week03Tests;

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
        Assert.Equal(["B", "C", "D"], myStack.GetStack());
    }

    [Fact]
    public void Undo()
    {
        var myStack = new MyStack();
        myStack.Type("A");
        myStack.Type("B");
        Assert.Equal("Undid B", myStack.Undo());
        Assert.Equal("Undid A", myStack.Undo());
        Assert.Equal("Stack is empty!", myStack.Undo());
    }

    [Fact]
    public void Redo()
    {
        var myStack = new MyStack();
        myStack.Type("A");
        myStack.Type("B");
        Assert.Equal("Undid B", myStack.Undo());
        Assert.Equal("Redid B", myStack.Redo());
        Assert.Equal(["A", "B"], myStack.GetStack());
        Assert.Equal(2, myStack.GetCount());
    }

    [Fact]
    public void Redo_Restores_Last_Undone_First()
    {
        var myStack = new MyStack();
        myStack.Type("A");
        myStack.Type("B");
        myStack.Type("C");
        myStack.Undo();
        myStack.Undo();
        myStack.Undo();

        Assert.Equal("Redid A", myStack.Redo());
        Assert.Equal("Redid B", myStack.Redo());
        Assert.Equal("Redid C", myStack.Redo());
        Assert.Equal(["A", "B", "C"], myStack.GetStack());
    }

    [Fact]
    public void Type_Clears_Redo()
    {
        var myStack = new MyStack();
        myStack.Type("A");
        myStack.Type("B");
        myStack.Undo();
        myStack.Type("C");

        Assert.Equal("Nothing to redo!", myStack.Redo());
        Assert.Equal(["A", "C"], myStack.GetStack());
    }

    [Fact]
    public void Redo_Empty()
    {
        var myStack = new MyStack();
        Assert.Equal("Nothing to redo!", myStack.Redo());
    }
}
