namespace Week03FooBar;

public class FooBar : IFooBar
{
    private static readonly (int Divisor, string Text)[] Rules =
    [
        (3, "foo"),
        (4, "baz"),
        (5, "bar"),
        (7, "jazz"),
        (9, "huzz")
    ];

    public string Evaluate(int x)
    {
        var result = "";
        foreach (var (divisor, text) in Rules)
            if (x % divisor == 0)
                result += text;

        return result.Length == 0 ? x.ToString() : result;
    }

    public string Generate(int n)
    {
        return string.Join(", ", Enumerable.Range(1, n).Select(Evaluate));
    }
}