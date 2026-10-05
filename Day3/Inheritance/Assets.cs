namespace Day3.Inheritance;

public class Asset
{
    public string Name = "";
    public virtual decimal Liability => 0;
}

public class Stock : Asset
{
    public long SharesOwned;
}

public class House : Asset
{
    public decimal Mortgage;
    public override decimal Liability => Mortgage;
}