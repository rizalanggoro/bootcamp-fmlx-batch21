using Day3.Interfaces;
using Classes = Day3.Classes;
using Inheritance = Day3.Inheritance;
using Struct = Day3.Struct;
using Access = Day3.Access.Modifiers;
using Enums = Day3.Enums;
using Gen = Day3.Generics;

Console.WriteLine("Hello, World!");

var stock = new Classes.Stock { CurrentPrice = 30, SharesOwned = 10 };
Console.WriteLine(stock.Worth);

var adder = new Classes.Adder();
Console.WriteLine(adder.Add(1, 2));
Console.WriteLine(adder.Add(1.5, 2.5));
Console.WriteLine(adder.Add(1, 2, 3));

var rect = new Classes.Rectangle(3, 4);
Console.WriteLine($"Area: {rect.Area()}");
var (width, height) = rect;
Console.WriteLine($"{width} {height}");

var s = new Classes.Sentence();
Console.WriteLine(s[3]);
Console.WriteLine(s[^1]);
Console.WriteLine(string.Join(",", s[..2]));

var person = new Classes.Person { FirstName = "Alice", LastName = "Jones" };
Console.WriteLine(person.FullName);

var mansion = new Inheritance.House { Name = "Mansion", Mortgage = 250000 };
Inheritance.Asset asset = mansion;
Console.WriteLine(mansion.Liability);
Console.WriteLine(asset.Liability);

var child = new Inheritance.KeywordChild();
Inheritance.KeywordBase childAsBase = child;
Console.WriteLine($"override: via Child = {child.Label}, via Base = {childAsBase.Label} (sama, polymorphism)");

var hider = new Inheritance.KeywordHider();
Inheritance.KeywordBase hiderAsBase = hider;
Console.WriteLine(
    $"new/hide: via Hider = {hider.Label}, via Base = {hiderAsBase.Label} (beda, ikut tipe compile-time)");

var final = new Inheritance.KeywordFinal();
Console.WriteLine($"sealed class: {final} (tidak bisa diwarisi)");

var p1 = new Struct.Point(1, 2);
var p2 = p1;
Console.WriteLine($"struct copy: p1=({p1.X},{p1.Y}) p2=({p2.X},{p2.Y})");

Span<int> nums = stackalloc int[3] { 1, 2, 3 };
var buf = new Struct.StackBuffer(nums);
Console.WriteLine($"ref struct sum: {buf.Sum()}");

var accessDemo = new Access.Demo();
Console.WriteLine(accessDemo.InternalX);

Console.WriteLine($"current counter value: {Counter.Num}");
Counter.Num++;
Console.WriteLine($"current counter value: {Counter.Num}");

var leftRight = Enums.BorderSides.Left | Enums.BorderSides.Right;
Console.WriteLine($"flags: {leftRight}");
Console.WriteLine($"includes Left: {(leftRight & Enums.BorderSides.Left) != 0}");

var stack = new Gen.Stack<int>();
stack.Push(5);
stack.Push(10);
Console.WriteLine($"generic stack: {stack.Pop()}, {stack.Pop()}");

var x = 5; var y = 10;
Gen.Util.Swap(ref x, ref y);
Console.WriteLine($"generic swap: {x}, {y}");
Console.WriteLine($"generic max: {Gen.Util.Max(3, 7)}");

var mstack = new Gen.Stack<Gen.Money>();
mstack.Push(new Gen.Money(5));
mstack.Push(new Gen.Money(10));
Console.WriteLine($"money stack: {mstack.Pop()}, {mstack.Pop()}");
Console.WriteLine($"money max: {Gen.Util.Max(new Gen.Money(5), new Gen.Money(10))}");