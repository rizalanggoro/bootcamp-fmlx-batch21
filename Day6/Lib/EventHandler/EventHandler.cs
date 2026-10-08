namespace Day6.Lib.EventHandler;

internal class EventHandler
{
    internal void Invoke()
    {
        Util.WriteHeader("Event Handler");

        {
            var transactionRepository = new TransactionRepository();
            TransactionChangedHandler transactionChangedHandler = User1;
            transactionChangedHandler += User2;
            transactionChangedHandler += User3;

            transactionRepository.Create(10_000, transactionChangedHandler);
            transactionRepository.Create(20_000, transactionChangedHandler);
        }

        {
            Console.WriteLine("\nUsing event and delegate");

            var transactionRepository = new TransactionRepository();
            transactionRepository.TransactionChangedHandler += User1;
            transactionRepository.TransactionChangedHandler += User2;
            transactionRepository.TransactionChangedHandler += User3;

            transactionRepository.Create(10_000);
            transactionRepository.Create(20_000);
        }

        {
            Console.WriteLine("\nUsing event handler from dotnet");

            var transactionRepository = new TransactionRepository();
            transactionRepository.TransactionChangedEventHandler += User1;
            transactionRepository.TransactionChangedEventHandler += User2;
            transactionRepository.TransactionChangedEventHandler += User3;

            transactionRepository.Create(10_000);
            transactionRepository.Create(20_000);
        }
    }

    private void User1(Transaction[] transactions)
    {
        Console.WriteLine($"User1 listen to {transactions.Length} transactions.");
    }

    private void User1(object? sender, Transaction[] transactions)
    {
        Console.WriteLine($"User1 listen to {transactions.Length} transactions.");
    }

    private void User2(Transaction[] transactions)
    {
        Console.WriteLine($"User2 listen to {transactions.Length} transactions.");
    }

    private void User2(object? sender, Transaction[] transactions)
    {
        Console.WriteLine($"User2 listen to {transactions.Length} transactions.");
    }

    private void User3(Transaction[] transactions)
    {
        Console.WriteLine($"User3 listen to {transactions.Length} transactions.");
    }

    private void User3(object? sender, Transaction[] transactions)
    {
        Console.WriteLine($"User3 listen to {transactions.Length} transactions.");
    }
}