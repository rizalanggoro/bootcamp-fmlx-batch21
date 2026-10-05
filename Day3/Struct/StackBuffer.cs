namespace Day3.Struct;

public ref struct StackBuffer
{
    public Span<int> Data;

    public StackBuffer(Span<int> data) => Data = data;

    public int Sum()
    {
        var total = 0;
        foreach (var n in Data)
            total += n;
        return total;
    }
}
