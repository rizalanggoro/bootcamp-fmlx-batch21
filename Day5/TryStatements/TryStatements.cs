namespace Day5.TryStatements;

public class TryStatements
{
    public void Invoke()
    {
        Console.WriteLine("---------- Try Statements ----------");

        try
        {
            var myRepo = new MyRepo();
            myRepo.DoSomething(false);

            Console.WriteLine("trigger exception manually");
            myRepo.DoSomething(true);
        }
        catch (MyRepo.MyRepoException e)
        {
            Console.WriteLine($"exception: {e.Message}");
        }
        finally
        {
            Console.WriteLine("finally!");
        }
    }

    private class MyRepo
    {
        internal void DoSomething(bool triggerException)
        {
            if (triggerException)
                throw new MyRepoException();

            Console.WriteLine("DoSomething called!");
        }

        internal class MyRepoException : Exception
        {
            public override string Message => "uh ohh!";
        }
    }
}