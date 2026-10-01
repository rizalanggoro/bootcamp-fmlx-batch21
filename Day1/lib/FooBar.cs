namespace MyLib;

public class FooBar
{
    public string Generate(int n)
    {
        string result = "";

        for (int i = 1; i <= n; i++)
        {
            string val;
            if (i % 3 == 0 && i % 5 == 0)
                val = "foobar";
            else if (i % 3 == 0)
                val = "foo";
            else if (i % 5 == 0)
                val = "bar";
            else
                val = i.ToString();

            result += i < n ? val + ", " : val;
        }

        return result;
    }
}