using Delegate = Day6.Lib.Delegate.Delegate;

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
}