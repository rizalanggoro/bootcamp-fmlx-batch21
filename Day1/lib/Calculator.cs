namespace MyLib
{
    public class Calculator
    {
        public int Sum(params int[] nums)
        {
            var total = 0;
            foreach (var a in nums)
            {
                total += a;
            }

            return total;
        }

        private int[] _tempNumbers = [];

        public void AddForSum(int num)
        {
            Array.Resize(ref _tempNumbers, _tempNumbers.Length + 1);
            _tempNumbers[_tempNumbers.Length - 1] = num;
        }

        public int Sum()
        {
            return _tempNumbers.Sum();
        }
    }
}