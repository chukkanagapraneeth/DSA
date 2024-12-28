// Remember the formula - Occurance of a digit in sub array = (i + 1) * (n - i)

namespace SumOfSubarrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3];
            Solution solution = new Solution();
            Console.WriteLine(solution.subArraySum(arr));
        }
        class Solution
        {
            public long subArraySum(int[] arr)
            {
                const int mod = 1_000_000_007;
                long sum = 0;
                int n = arr.Length;

                for(int i = 0; i < arr.Length; i++)
                {
                    long cont = (long)arr[i] * (i + 1) * (n - i);

                    sum = (sum + cont) % mod;
                }
                return sum;
            }
        }
    }
}
