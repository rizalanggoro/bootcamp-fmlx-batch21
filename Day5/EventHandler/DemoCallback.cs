namespace Day5.EventHandler;

file class MyRepo
{
    internal void DoSomething(ICallback callback)
    {
        var rand = new Random().Next() % 2 == 0;
        if (rand) callback.OnSuccess();
        else callback.OnFailure("something went wrong");
    }

    internal interface ICallback
    {
        void OnSuccess();
        void OnFailure(string message);
    }
}

internal class DemoCallback
{
    internal void Invoke()
    {
        var myRepo = new MyRepo();
        myRepo.DoSomething(new RepoCallback());
    }

    private class RepoCallback : MyRepo.ICallback
    {
        public void OnSuccess()
        {
            Console.WriteLine("[DemoCallback] OnSuccess");
        }

        public void OnFailure(string message)
        {
            Console.WriteLine($"[DemoCallback] OnFailure: {message}");
        }
    }
}