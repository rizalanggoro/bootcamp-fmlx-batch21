namespace Day3.Struct;

public readonly struct Point
{
    public readonly int X, Y;

    public Point(int x, int y)
    {
        (X, Y) = (x, y);
    }
}

public readonly struct NewPoint(int a, int b)
{
    public readonly NewPoint GetCopy()
    {
        return new NewPoint(
            a * 2,
            b * 2
        );
    }
}