using System.Collections;

namespace Day6.Lib.Enumeration;

internal class Enumeration
{
    internal void Invoke()
    {
        Util.WriteHeader("Enumeration");

        var names = new[]
        {
            "Rizal",
            "Dwi",
            "Anggoro"
        };

        foreach (var name in new ToLowerCase(names))
            Console.WriteLine(name);

        Console.WriteLine("\nvowels only");
        foreach (var name in VowelsOnly(new ToLowerCase(names)))
            Console.WriteLine(name);
    }

    private IEnumerable<string> VowelsOnly(IEnumerable<string> names)
    {
        var vowels = new[] { "a", "i", "u", "e", "o" };

        foreach (var name in names)
        {
            var result = "";
            foreach (var word in name)
            {
                var strWord = word.ToString();
                if (vowels.Contains(strWord))
                    result += strWord;
                else
                    result += "_";
            }

            yield return result;
        }
    }

    private class ToLowerCase(string[] names) : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            return new Enumerator(names);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class Enumerator(string[] names) : IEnumerator<string>
        {
            private int _currentIndex;

            public bool MoveNext()
            {
                if (_currentIndex >= names.Length) return false;

                Current = names[_currentIndex].ToLower();
                _currentIndex++;

                return true;
            }

            public void Reset()
            {
                _currentIndex = 0;
                Current = names[_currentIndex];
            }

            public string Current { get; private set; } = "";

            object? IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}