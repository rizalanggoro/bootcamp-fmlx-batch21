using Week03FooBar;

namespace Week03Tests;

public class FooBarTest
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(11, "11")]
    [InlineData(3, "foo")]
    [InlineData(4, "baz")]
    [InlineData(5, "bar")]
    [InlineData(7, "jazz")]
    [InlineData(9, "foohuzz")]
    [InlineData(12, "foobaz")]
    [InlineData(15, "foobar")]
    [InlineData(20, "bazbar")]
    [InlineData(21, "foojazz")]
    [InlineData(28, "bazjazz")]
    [InlineData(35, "barjazz")]
    [InlineData(36, "foobazhuzz")]
    [InlineData(45, "foobarhuzz")]
    [InlineData(63, "foojazzhuzz")]
    [InlineData(105, "foobarjazz")]
    [InlineData(180, "foobazbarhuzz")]
    public void Evaluate(int x, string expected)
    {
        Assert.Equal(expected, new FooBar().Evaluate(x));
    }

    [Fact]
    public void Generate()
    {
        Assert.Equal(
            "1, 2, foo, baz, bar, foo, jazz, baz, foohuzz, bar, 11, foobaz, 13, jazz, foobar",
            new FooBar().Generate(15)
        );
    }
}