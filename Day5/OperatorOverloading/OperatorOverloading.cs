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

        var note5 = note4 - note2;
        Console.WriteLine(note5);
    }

    private class MyNote(string content)
    {
        private readonly string _content = content;

        public static MyNote operator +(MyNote a, MyNote b)
        {
            return new MyNote(Strings.Join([a._content, b._content]) ?? "");
        }

        public static MyNote operator -(MyNote a, MyNote b)
        {
            var contents = a._content.Split(" ");
            var filteredContents = contents.Where(
                item => item != b._content
            );

            return new MyNote(Strings.Join([..filteredContents]) ?? "");
        }

        public override string ToString()
        {
            return _content;
        }
    }
}