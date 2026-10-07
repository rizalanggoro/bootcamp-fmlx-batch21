namespace Day5.Delegate;

public class Index
{
    private int Square(int x)
    {
        return x * x;
    }

    private float Square(float x)
    {
        return x * x;
    }

    private int Cube(int x)
    {
        return x * x * x;
    }

    private void MulticastMethod1()
    {
        Console.WriteLine("Multicast method 1");
    }

    private void MulticastMethod2()
    {
        Console.WriteLine("Multicast method 2");
    }

    private void SayHello(string name)
    {
        Console.WriteLine($"Hello {name}");
    }

    public void Invoke()
    {
        {
            Console.WriteLine("---------- Delegate ----------");
            var transformers = new Transformer[] { Square, Cube };

            var values = new[] { 2, 3 };
            foreach (var value in values)
            {
                Console.WriteLine($"value: {value}");
                foreach (var transformer in transformers)
                {
                    var name = transformer == Square ? "square" : "cube";
                    Console.WriteLine($" - {name}: {transformer(value)}");
                }
            }
        }

        {
            Console.WriteLine("---------- Multicast Delegate ----------");

            MulticastDelegate multi = MulticastMethod1;
            multi += MulticastMethod2;
            multi += MulticastMethod1;

            multi.Invoke();
        }

        {
            Console.WriteLine("---------- Generic Delegate Types ----------");

            Transformer<int> t1 = Square;
            Transformer<float> t2 = Square;

            Console.WriteLine($"square int  : {t1(2)}");
            Console.WriteLine($"square float: {t2(2.2f)}");
        }

        {
            Console.WriteLine("---------- Func and Action Delegate ----------");

            Console.WriteLine($"square int  : {SomeFunc(2, Square)}");
            Console.WriteLine($"square float: {SomeFunc(2.2f, Square)}");

            SomeAction("Rizal", SayHello);
            SomeAction("Anggoro", SayHello);
        }
    }

    private static T SomeFunc<TArg, T>(TArg arg, Func<TArg, T> func)
    {
        return func(arg);
    }

    private static void SomeAction<TArg>(TArg arg, Action<TArg> action)
    {
        action(arg);
    }

    private delegate int Transformer(int x);

    private delegate T Transformer<T>(T arg);

    private delegate void MulticastDelegate();
}