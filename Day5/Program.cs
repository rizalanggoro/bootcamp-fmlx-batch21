using Delegate = Day5.Delegate;
using EventHandler = Day5.EventHandler;
using TryStatements = Day5.TryStatements.TryStatements;
using Enumeration = Day5.Enumeration.Enumeration;

var runIndex = 3;
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
}