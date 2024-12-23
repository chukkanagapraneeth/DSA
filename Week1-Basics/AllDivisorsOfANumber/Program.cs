using System.Text;

namespace AllDivisorsOfANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.print_divisors(9);
        }
        class Solution
        {
            //Complete this function
            //Function to print all the divisors of the given number.
            // Time complexity is O(sqrt(n)) -- IMPORTANT
            public void print_divisors(int n)
            {
                StringBuilder res = new StringBuilder();
                for(int i = 1; i * i <= n; i++)
                {
                    if(n % i == 0)
                    {
                        res.Append($"{i} ");
                        //Console.WriteLine(i);
                    }
                }

                for(int j = (int)Math.Sqrt(n); j >= 1; j--)
                {
                    if(n % j == 0 && j != n / j)
                    {
                        res.Append($"{n / j} ");
                        //Console.WriteLine();
                    }
                }

                Console.WriteLine(res.ToString());
            }
        }
    }
}
