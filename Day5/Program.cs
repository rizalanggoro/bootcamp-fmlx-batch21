using Delegate = Day5.Delegate;
using EventHandler = Day5.EventHandler;
using TryStatements = Day5.TryStatements.TryStatements;
using Enumeration = Day5.Enumeration.Enumeration;
using OperatorOverloading = Day5.OperatorOverloading.OperatorOverloading;

var runIndex = 6;
switch (runIndex)
{
    case 0:
        new Delegate.Index().Invoke();
        break;

    case 1:
        new EventHandler.Index().Invoke();
        break;

    case 2:
        new TryStatements().Invoke();
        break;

    case 3:
        new Enumeration().Invoke();
        break;

    case 5:
        new OperatorOverloading().Invoke();
        break;

    case 6:
        new EventHandler.DemoCallback().Invoke();
        break;
}