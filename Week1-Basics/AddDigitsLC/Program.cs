namespace AddDigitsLC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.AddDigits(38));
        }
        public class Solution
        {
            public int AddDigits(int num)
            {
                return recuFunction(num);
            }

            public int recuFunction(int num)
            {
                if(num < 10)
                {
                    return num;
                }

                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                return recuFunction(sum);
            }
        }
    }
}
