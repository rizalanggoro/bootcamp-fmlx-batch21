using System.Collections;

namespace Day5.Enumeration;

public class Enumeration
{
    public void Invoke()
    {
        Console.WriteLine("---------- Enumeration ----------");

        foreach (var item in new Counter(10)) Console.WriteLine($"item: {item}");
    }

    private class Counter(int toNumber) : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new CounterEnumerator(toNumber);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class CounterEnumerator(int toNumber) : IEnumerator<int>
        {
            public bool MoveNext()
            {
                Current++;
                return Current <= toNumber;
            }

            public void Reset()
            {
                Current = 0;
            }

            public int Current { get; private set; }

            object? IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}