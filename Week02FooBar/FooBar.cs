namespace Week02FooBar;

public class FooBar
{
    public void Generate(int n)
    {
        for (var x = 1; x <= n; x++)
        {
            if (x > 1)
                Console.Write(", ");

            var result = "";
            if (x % 3 == 0)
                result += "foo";

            if (x % 5 == 0)
                result += "bar";

            if (x % 7 == 0)
                result += "jazz";

            if (result.Length == 0)
                result = x.ToString();

            Console.Write(result);
        }

        Console.WriteLine();
    }
}