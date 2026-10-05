namespace Day3.Access.Modifiers;

public class Demo
{
    private int _privateX;
    internal int InternalX;
    private protected int PrivateProtectedX;
    protected internal int ProtectedInternalX;
    protected int ProtectedX;
    public int PublicX;

    public int ReadPrivate()
    {
        return _privateX;
    }
}

public class DemoChild : Demo
{
    public int ReadProtected()
    {
        return ProtectedX;
    }

    private void Test()
    {
        var a = ProtectedInternalX;
    }
}

file class FileHelper;