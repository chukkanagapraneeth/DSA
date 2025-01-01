// Exponentiation by Squaring

namespace Pow_X_N_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 2; int n = 3;
            Solution solution = new Solution();
            Console.WriteLine(solution.MyPow(x,n));
        }
        public class Solution
        {
            public double MyPow(double x, int n)
            {
                long absN = Math.Abs((long)n); // to handle int abs value so we take long

                double result = MyPowRecuHelper(x, absN);

                return n < 0 ? 1 / result : result;
            }

            public double MyPowRecuHelper(double x, long n)
            {
                if(n == 0)
                {
                    return 1; // Base Case x^0 = 1;
                }

                double half = MyPowRecuHelper(x, n / 2);

                return n % 2 == 0 ? half * half : half * half * x;
            } 
        }
    }
}
