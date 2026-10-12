// See https://aka.ms/new-console-template for more information

using Week02FooBar;

Console.Write("Enter n: ");
var n = int.Parse(Console.ReadLine() ?? "15");

var foobar = new FooBar();
foobar.Generate(n);