using Week01FooBar;

Console.Write("Enter n: ");
var n = int.Parse(Console.ReadLine() ?? "15");

var foobar = new FooBar();
foobar.Generate(n);