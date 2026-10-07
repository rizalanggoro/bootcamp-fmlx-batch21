namespace Day5.EventHandler;

public class Index
{
    public void Invoke()
    {
        {
            Console.WriteLine("---------- Event Handler ----------");

            var repo = new Repo();

            repo.Completed += _repoCallback;
            repo.DoSomething();
        }

        {
            Console.WriteLine("---------- Calc Event Handler ----------");

            var calculator = new Calculator();
            calculator.Result += (_, argument) =>
                Console.WriteLine($"[{argument.Operation}] {argument.Result}");

            calculator.Add(1.2, 2.3);
            calculator.Subtract(5.4, 3.2);
        }
    }

    private void _repoCallback(object? sender, bool status)
    {
        Console.WriteLine($"repo callback status: {status}");
    }

    private class Calculator
    {
        internal event EventHandler<Argument>? Result;

        internal void Add(double num1, double num2)
        {
            OnResult(new Argument(Operation.Add, num1 + num2));
        }

        internal void Subtract(double num1, double num2)
        {
            OnResult(new Argument(Operation.Sub, num1 - num2));
        }

        private void OnResult(Argument e)
        {
            Result?.Invoke(this, e);
        }

        internal enum Operation
        {
            Add,
            Sub
        }

        internal class Argument(Operation operation, double result) : EventArgs
        {
            public Operation Operation { get; } = operation;
            public double Result { get; } = result;
        }
    }

    private sealed class Repo
    {
        internal event EventHandler<bool>? Completed;

        internal void DoSomething()
        {
            var rand = new Random().Next() % 2 == 0;
            OnEventHandler(rand);
        }

        private void OnEventHandler(bool status)
        {
            Completed?.Invoke(this, status);
        }
    }
}