namespace Week04FooBar;

public interface IFooBar
{
    void AddRule(int divisor, string output);
    string Evaluate(int number);
    string GenerateSequence(int start, int end);
}
