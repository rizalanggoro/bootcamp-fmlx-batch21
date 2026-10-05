namespace Day3.Classes;

public class Stock
{
    private decimal _currentPrice;

    public decimal CurrentPrice
    {
        get => _currentPrice;
        set => _currentPrice = value < 0 ? throw new ArgumentOutOfRangeException(nameof(value)) : value;
    }

    public decimal SharesOwned { get; init; }

    public decimal Worth => _currentPrice * SharesOwned;

    public readonly DateTime CreatedAt = DateTime.Now;
    public static readonly DateTime StartupTime = DateTime.Now;
}
