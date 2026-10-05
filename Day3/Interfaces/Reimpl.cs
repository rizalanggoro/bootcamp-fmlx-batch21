namespace Day3.Interfaces;

public class ExplicitBox : IUndoable
{
    void IUndoable.Undo()
    {
        Undo();
    }

    public virtual void Undo()
    {
        Console.WriteLine("ExplicitBox.Undo");
    }
}

public class ReBox : ExplicitBox
{
    public override void Undo()
    {
        Console.WriteLine("ReBox.Undo");
    }
}

public class Test
{
    private static void test()
    {
        var box = new ReBox();
        box.Undo();
        ((IUndoable)box).Undo();
    }
}