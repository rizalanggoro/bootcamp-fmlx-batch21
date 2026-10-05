namespace Day3.Generics;

public readonly struct Money : IComparable<Money>
{
    public readonly decimal Amount;

    public Money(decimal amount) => Amount = amount;

    public int CompareTo(Money other) => Amount.CompareTo(other.Amount);

    public override string ToString() => $"{Amount}";
}
