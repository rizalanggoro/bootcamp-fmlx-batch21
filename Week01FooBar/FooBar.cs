namespace Week01FooBar;

public class FooBar
{
    public void Generate(int n)
    {
        for (var x = 1; x <= n; x++)
        {
            if (x > 1)
                Console.Write(", ");

            if (x % 3 == 0 && x % 5 == 0)
                Console.Write("foobar");
            else if (x % 3 == 0)
                Console.Write("foo");
            else if (x % 5 == 0)
                Console.Write("bar");
            else
                Console.Write(x);
        }

        Console.WriteLine();
    }
}