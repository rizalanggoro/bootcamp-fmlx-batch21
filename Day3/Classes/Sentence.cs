namespace Day3.Classes;

public class Sentence
{
    private readonly string[] _words = "The quick brown fox".Split();

    public string this[int wordNum]
    {
        get => _words[wordNum];
        set => _words[wordNum] = value;
    }

    public string this[Index index] => _words[index];
    public string[] this[Range range] => _words[range];
}
