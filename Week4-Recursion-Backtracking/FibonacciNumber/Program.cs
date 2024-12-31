namespace FibonacciNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 4;
            Solution solution = new Solution();
            Console.WriteLine(solution.Fib(k));
        }
        public class Solution
        {
            public int Fib(int n)
            {
                return FibHelper(n);
            }

            public int FibHelper(int n)
            {
                if (n == 0) return 0;
                if (n == 1) return 1;

                int x = FibHelper(n - 1) + FibHelper(n - 2);

                return x;
            }
        }
    }
}
