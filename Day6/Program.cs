using Delegate = Day6.Lib.Delegate.Delegate;
using EventHandler = Day6.Lib.EventHandler.EventHandler;

if (args.Length == 0)
{
    Console.WriteLine("run using arguments -- <delegate>");
    return;
}

var runType = args[0];
switch (runType)
{
    case "delegate":
        new Delegate().Invoke();
        break;

    case "event-handler":
        new EventHandler().Invoke();
        break;
}