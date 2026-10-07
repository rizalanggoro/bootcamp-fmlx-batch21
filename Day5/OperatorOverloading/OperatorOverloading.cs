using Microsoft.VisualBasic;

namespace Day5.OperatorOverloading;

public class OperatorOverloading
{
    public void Invoke()
    {
        Console.WriteLine("---------- Operator Overloading ----------");

        var note1 = new MyNote("hello");
        var note2 = new MyNote("world");
        var note3 = new MyNote("!");

        var note4 = note1 + note2 + note3;
        Console.WriteLine(note4);
    }

    private class MyNote(string content)
    {
        private readonly string _content = content;

        public static MyNote operator +(MyNote a, MyNote b)
        {
            return new MyNote(Strings.Join([a._content, b._content]) ?? "");
        }

        public override string ToString()
        {
            return _content;
        }
    }
}