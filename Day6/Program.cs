using Day6.Lib.Enumeration;
using Day6.Lib.OperatorOverloading;
using Day6.Lib.TryStatements;
using Delegate = Day6.Lib.Delegate.Delegate;
using EventHandler = Day6.Lib.EventHandler.EventHandler;

try
{
    var runType = args[0];
    switch (runType)
    {
        case "delegate":
            new Delegate().Invoke();
            break;

        case "event-handler":
            new EventHandler().Invoke();
            break;

        case "try-statements":
            new TryStatements().Invoke();
            break;

        case "enumeration":
            new Enumeration().Invoke();
            break;

        case "operator-overloading":
            new OperatorOverloading().Invoke();
            break;
    }
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("run using arguments -- <delegate>");
}
finally
{
    Console.WriteLine("Exiting program...");
}