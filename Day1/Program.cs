// See https://aka.ms/new-console-template for more information
using MyLib;

var rand = new Random();
var calc = new Calculator();

Console.WriteLine($"sum: {calc.Sum(1, 2, 3, 4)}");

var count = (rand.Next() % 10) + 1;

for (var a = 0; a < count; a++)
{
    var num = (rand.Next() % 5) + 1;
    calc.AddForSum(num);

    Console.Write(a < count - 1 ? $"{num} + " : $"{num} = {calc.Sum()}\n");
}

var foobar = new FooBar();
Console.WriteLine(foobar.Generate(15));
