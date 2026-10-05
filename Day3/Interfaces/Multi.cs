namespace Day3.Interfaces;

public interface IRedoable
{
    void Redo();
}

public class Editor : IUndoable, IRedoable
{
    public void Redo()
    {
        Console.WriteLine("Editor.Redo");
    }

    public void Undo()
    {
        Console.WriteLine("Editor.Undo");
    }
}

public abstract class ASample
{
    protected int _counter; // OK: abstract class boleh punya state/field

    public abstract void Method1();

    public string Method2()
    {
        return "hello world";
    }

    public int Next()
    {
        return ++_counter;
    }
}

public interface ISample
{
    // int _counter; // Error: interface tidak boleh punya instance field/state

    public void Method1();

    public string Method2()
    {
        return "hello world";
    }
}

internal class Sample1 : ASample
{
    public override void Method1()
    {
        var test = _counter;
        throw new NotImplementedException();
    }
}

internal class Sample2 : ISample
{
    public void Method1()
    {
        throw new NotImplementedException();
    }
}