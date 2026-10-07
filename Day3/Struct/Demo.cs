internal struct Demo
{
    public int x = 0;
    public int y = 0;

    public Demo()
    {
        (x, y) = (0, 0);
    }
}

internal class StructDemo
{
    private void Test()
    {
        var test = new Demo();
        Demo test2 = new();
        Demo test3 = default;
    }
}