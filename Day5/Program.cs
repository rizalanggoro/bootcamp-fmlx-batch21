using Delegate = Day5.Delegate;
using EventHandler = Day5.EventHandler;

var runIndex = 1;
switch (runIndex)
{
    case 0:
        new Delegate.Index().Invoke();
        break;

    case 1:
        new EventHandler.Index().Invoke();
        break;
}