namespace Day3.Inheritance;

public abstract class DemoAsset
{
    public string Name = "hello world";
    public abstract decimal NetValue { get; }
    public virtual decimal Liability => 0;

    public abstract decimal Calculate();
}

public class DemoStock : DemoAsset
{
    public override decimal NetValue => 100;

    public override decimal Calculate()
    {
        throw new NotImplementedException();
    }
}

public class DemoHouse : DemoAsset
{
    public override decimal NetValue => 200;
    public override decimal Liability => 50;

    public override decimal Calculate()
    {
        throw new NotImplementedException();
    }
}