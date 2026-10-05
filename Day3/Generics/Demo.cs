namespace Day3.Generics;

public class Stack<T>
{
    private readonly T[] _data = new T[100];
    private int _position;

    public void Push(T obj)
    {
        _data[_position++] = obj;
    }

    public T Pop()
    {
        return _data[--_position];
    }
}

public static class Util
{
    public static void Swap<T>(ref T a, ref T b)
    {
        (a, b) = (b, a);
    }

    public static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
}