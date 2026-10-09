namespace Day6.Lib.EventHandler;

internal class TransactionRepository
{
    private readonly List<Transaction> _transactions = [];

    internal event TransactionChangedHandler? TransactionChangedHandler;

    internal event EventHandler<Transaction[]>? TransactionChangedEventHandler;

    internal void Create(decimal amount, TransactionChangedHandler handler)
    {
        _transactions.Add(
            new Transaction(
                amount,
                DateTime.Now
            )
        );

        handler.Invoke(_transactions.ToArray());
    }

    internal void Create(decimal amount)
    {
        _transactions.Add(
            new Transaction(
                amount,
                DateTime.Now
            )
        );

        OnTransactionChangedHandler(_transactions.ToArray());
    }

    protected virtual void OnTransactionChangedHandler(Transaction[] transactions)
    {
        TransactionChangedHandler?.Invoke(transactions);
        TransactionChangedEventHandler?.Invoke(this, transactions);
    }
}