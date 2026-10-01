// See https://aka.ms/new-console-template for more information
using MyLib;

while (true)
{
    Console.WriteLine("====================================");
    Console.WriteLine("  Day1 - Pilih Exercise");
    Console.WriteLine("====================================");
    Console.WriteLine("  [1] Calculator");
    Console.WriteLine("  [2] FooBar");
    Console.WriteLine("  [3] Queue");
    Console.WriteLine("  [0] Keluar");
    Console.WriteLine("====================================");
    Console.Write("Pilih: ");
    var choice = Console.ReadLine();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("---------- Calculator ----------");
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
            Console.WriteLine("--------------------------------");
            break;

        case "2":
            Console.WriteLine("---------- FooBar ----------");
            var foobar = new FooBar();
            Console.WriteLine(foobar.Generate(15));
            Console.WriteLine("--------------------------------");
            break;

        case "3":
            Console.WriteLine("---------- Queue ----------");
            var queue = new MyQueue();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Process();
            queue.Process();
            Console.WriteLine("--------------------------------");
            break;

        default:
            Console.WriteLine("Bye!");
            return;
    }

    Console.WriteLine("Tekan Enter untuk kembali...");
    Console.ReadLine();
    Console.WriteLine();
}
