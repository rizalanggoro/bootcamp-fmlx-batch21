using Week04FooBar;

namespace Week04Tests;

public class FooBarTest
{
    private static FooBar Create()
    {
        var fooBar = new FooBar();
        fooBar.AddRule(5, "bar");
        fooBar.AddRule(3, "foo");
        fooBar.AddRule(7, "baz");
        return fooBar;
    }

    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "foo")]
    [InlineData(5, "bar")]
    [InlineData(7, "baz")]
    [InlineData(15, "foobar")]
    [InlineData(21, "foobaz")]
    [InlineData(35, "barbaz")]
    [InlineData(105, "foobarbaz")]
    public void Evaluate(int number, string expected)
    {
        Assert.Equal(expected, Create().Evaluate(number));
    }

    [Fact]
    public void Evaluate_Rules_Run_In_Ascending_Divisor_Order()
    {
        var fooBar = new FooBar();
        fooBar.AddRule(7, "baz");
        fooBar.AddRule(5, "bar");
        fooBar.AddRule(3, "foo");

        Assert.Equal("foobarbaz", fooBar.Evaluate(105));
    }

    [Fact]
    public void Evaluate_Without_Rules_Returns_Number()
    {
        Assert.Equal("3", new FooBar().Evaluate(3));
    }

    [Fact]
    public void AddRule_Replaces_Existing_Divisor()
    {
        var fooBar = new FooBar();
        fooBar.AddRule(3, "foo");
        fooBar.AddRule(3, "fizz");

        Assert.Equal("fizz", fooBar.Evaluate(9));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-3)]
    public void AddRule_Rejects_Non_Positive_Divisor(int divisor)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new FooBar().AddRule(divisor, "foo"));
    }

    [Fact]
    public void GenerateSequence()
    {
        Assert.Equal(
            "1, 2, foo, 4, bar, foo, baz, 8, foo, bar, 11, foo, 13, baz, foobar",
            Create().GenerateSequence(1, 15)
        );
    }

    [Fact]
    public void GenerateSequence_Empty_Range()
    {
        Assert.Equal("", Create().GenerateSequence(5, 1));
    }
}
