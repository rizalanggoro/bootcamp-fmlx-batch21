namespace Day6.Lib.EventHandler;

internal class Transaction(
    decimal amount,
    DateTime date)
{
    internal readonly decimal Amount = amount;
    internal readonly DateTime Date = date;
}