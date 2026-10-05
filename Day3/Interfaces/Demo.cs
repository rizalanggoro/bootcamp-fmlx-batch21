namespace Day3.Interfaces;

public interface IUndoable
{
    void Undo();
}

public class TextBox : IUndoable
{
    public virtual void Undo()
    {
        Console.WriteLine("TextBox.Undo");
    }
}

public class RichTextBox : TextBox
{
    public override void Undo()
    {
        Console.WriteLine("RichTextBox.Undo");
    }
}

public interface Counter
{
    public static int Num = 0;
}