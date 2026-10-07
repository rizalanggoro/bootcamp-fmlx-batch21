namespace Day5.Result;

public class ResultDemo
{
    internal void Invoke()
    {
        var result = DoSomething();
        if (result.IsOk)
            Console.WriteLine($"result ok: {result.Data}");
    }

    private DataResult<int> DoSomething()
    {
        if (new Random().Next() % 2 == 0)
            return DataResult<int>.Ok(13);
        return DataResult<int>.Fail(null);
    }

    internal class DataResult<T>(bool isOk, T? data, string? message = null)
    {
        internal readonly T? Data = data;
        internal readonly bool IsOk = isOk;
        internal readonly string? Message = message;

        internal static DataResult<T> Ok(T data)
        {
            return new DataResult<T>(true, data);
        }

        internal static DataResult<T> Fail(string? message = "Something went wrong")
        {
            return new DataResult<T>(false, default, message);
        }
    }
}