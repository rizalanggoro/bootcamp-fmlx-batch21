using Delegate = Day5.Delegate;
using EventHandler = Day5.EventHandler;
using TryStatements = Day5.TryStatements.TryStatements;
using Enumeration = Day5.Enumeration.Enumeration;
using OperatorOverloading = Day5.OperatorOverloading.OperatorOverloading;

if (args.Length == 0)
{
    Console.WriteLine("run with argument -- <delegate>");
    return;
}

var runType = args[0];
switch (runType)
{
    case "delegate":
        new Delegate.Index().Invoke();
        break;

    case "event-handler":
        new EventHandler.Index().Invoke();
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

    case "event-handler-2":
        new EventHandler.DemoCallback().Invoke();
        break;
}