using Week01FooBar;

Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine() ?? "15");

var foobar = new FooBar();
foobar.Generate(n);
