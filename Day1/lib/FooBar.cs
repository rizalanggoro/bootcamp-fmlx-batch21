namespace MyLib
{
    class FooBar
    {
        private string _result = "";

        private void AppendResult(string val, int index, int count)
        {
            _result += index < count ? $"{val}, " : val;
        }

        public string Generate(int count)
        {
            for (int a = 1; a < (count + 1); a++)
            {
                if (a % 3 == 0 && a % 5 == 0)
                    AppendResult("foobar", a, count);
                else if (a % 3 == 0)
                    AppendResult("foo", a, count);
                else if (a % 5 == 0)
                    AppendResult("bar", a, count);
                else
                    AppendResult(a.ToString(), a, count);
            }

            return _result;
        }
    }
}