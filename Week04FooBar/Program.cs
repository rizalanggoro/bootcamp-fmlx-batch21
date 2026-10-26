using Week04FooBar;

var fooBar = new FooBar();
fooBar.AddRule(3, "foo");
fooBar.AddRule(5, "bar");

Console.WriteLine(fooBar.Evaluate(15));
Console.WriteLine(fooBar.GenerateSequence(1, 15));
