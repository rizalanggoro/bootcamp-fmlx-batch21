namespace Day3.NestedTypes;

public class TopLevel
{
    public enum Color
    {
        Red,
        Blue,
        Tan
    }

    private static readonly int _x = 10;

    public class Nested
    {
        public static int GetX()
        {
            return _x;
        }
    }

    protected class ProtectedNested
    {
        public static string Who()
        {
            return "protected";
        }

        protected string Test()
        {
            return "test";
        }
    }
}

public class SubTopLevel : TopLevel
{
    public static string UseProtected()
    {
        return ProtectedNested.Who();
    }

    private class A : ProtectedNested
    {
        private void test()
        {
            var test = Test();
        }
    }
}

internal class TestTop
{
    internal class Inner
    {
        internal string Name = "hello world";

        internal enum Color
        {
            R,
            G,
            B
        }
    }
}

internal class DemoNested
{
    private void Main()
    {
        var name = new TestTop.Inner().Name;
        var color = TestTop.Inner.Color.R;
    }
}