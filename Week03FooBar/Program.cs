using Week03FooBar;

Console.Write("Enter n: ");
var n = int.Parse(Console.ReadLine() ?? "15");

Console.WriteLine(new FooBar().Generate(n));
