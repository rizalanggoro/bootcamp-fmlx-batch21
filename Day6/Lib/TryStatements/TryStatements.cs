using Day6.Lib.EventHandler;

namespace Day6.Lib.TryStatements;

internal class TryStatements
{
    internal void Invoke()
    {
        Util.WriteHeader("Try Statements");

        Console.WriteLine("divide 1 by 1");
        var result = DoDivision(1, 1);
        Console.WriteLine($"result: {result}");

        Console.WriteLine("\ndivide 1 by 0");
        result = DoDivision(1, 0);
        Console.WriteLine($"result: {result?.ToString() ?? "error"}");
    }

    private void Test()
    {
        var user = new UserDto
        {
            Id = 1
        };

        Console.WriteLine($"User id: {user.Id}");
    }


    private int? DoDivision(int num1, int num2)
    {
        try
        {
            return num1 / num2;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
        finally
        {
            Console.WriteLine("finally block!");
        }
    }
}