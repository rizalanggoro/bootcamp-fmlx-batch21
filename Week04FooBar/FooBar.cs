namespace Week04FooBar;

public class FooBar : IFooBar
{
    private readonly Dictionary<int, string> _rules = new();

    public void AddRule(int divisor, string output)
    {
        if (divisor <= 0)
            throw new ArgumentOutOfRangeException(nameof(divisor), "Divisor must be greater than zero.");

        _rules[divisor] = output;
    }

    public string Evaluate(int number)
    {
        var result = string.Concat(
            _rules
                .OrderBy(rule => rule.Key)
                .Where(rule => number % rule.Key == 0)
                .Select(rule => rule.Value)
        );

        return result.Length == 0 ? number.ToString() : result;
    }

    public string GenerateSequence(int start, int end)
    {
        if (end < start)
            return "";

        return string.Join(", ", Enumerable.Range(start, end - start + 1).Select(Evaluate));
    }
}
