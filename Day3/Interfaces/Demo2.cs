internal interface IDemo
{
    void Method1();
}

internal abstract class BaseClass : IDemo
{
    void IDemo.Method1()
    {
        throw new NotImplementedException();
    }
}

internal class SubClass : BaseClass, IDemo
{
    public void Method1()
    {
        throw new NotImplementedException();
    }
}

internal class InterfaceDemo
{
    private void Test()
    {
        var subClass = new SubClass();
        subClass.Method1();
        ((IDemo)subClass).Method1();
        // ((BaseClass)subClass).Method1();
    }
}

internal interface ITypeDescribable
{
    static abstract string Description { get; } // Must be implemented
    static virtual string? Category => null; // Optional implementation
}

internal class CustomerTest : ITypeDescribable
{
    public static string Description => "";
    public static string Category => "Unit testing"; // Optional implementation
}