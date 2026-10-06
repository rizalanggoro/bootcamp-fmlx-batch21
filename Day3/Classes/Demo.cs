internal class Demo1
{
    private int _age;
    private string _name;
    public string PublicTest = "hello world";

    internal Demo1(int age, string name)
    {
        (_age, _name) = (age, name);
    }
}

internal class Demo2
{
    private readonly int _counter = 0;

    internal int this[int index] => _counter + index;
}

internal class Demo3(string firstName, string lastName)
{
    internal readonly string FirstName = firstName;
    internal string FullName => $"{firstName} {lastName}";
    internal string LastName { get; } = lastName;
}

internal class Demo4(string firstName, string lastName)
{
    static Demo4()
    {
        StartedAt = DateTime.UtcNow.ToString("o");
    }

    public Demo4(string name) : this(name, "")
    {
    }

    internal static string StartedAt { get; }

    internal void Test()
    {
        var a = firstName;
    }
}

internal class Demo5
{
    internal Demo5(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("wajib isi", nameof(name));
        Name = name;
    }

    internal string Name { get; }
}

internal class Program1
{
    private static void Index()
    {
        var demo4 = new Demo4("");

        var demo31 = new Demo3("John", "Doe");
        var demo32 = demo31.FullName;
        var demo33 = demo31.FirstName;
        var demo34 = demo31.LastName;

        var demo1 = new Demo1(12, "nama");
        var demo2 = new Demo1(12, "name") { PublicTest = "hehe" };

        var demo21 = new Demo2();
        var demo22 = demo21[0];
    }
}