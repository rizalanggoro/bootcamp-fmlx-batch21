namespace Day7;

public class Test
{
    internal void Invoke()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write("hello world");
        Console.CursorLeft -= 5;
        Console.Write("rizal");
        Console.WriteLine();
    }
}