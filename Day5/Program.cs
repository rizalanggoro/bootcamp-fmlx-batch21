using Delegate = Day5.Delegate;
using EventHandler = Day5.EventHandler;
using TryStatements = Day5.TryStatements.TryStatements;

var runIndex = 2;
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
}