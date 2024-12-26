//https://www.geeksforgeeks.org/problems/missing-number-in-array1416/1

//Intution - Calculate full sum and subtract it minus n (n + 1) / 2

// To avoid integer overflow use long

namespace MissingInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1];
            Solution solution = new Solution();
            Console.WriteLine(solution.missingNumber(arr));
        }
        class Solution
        {
            public int missingNumber(int[] arr)
            {
                int n = arr.Max();
                int totalSum = (n * (n + 1) )/ 2;
                int sum = arr.Sum();
                return totalSum - sum == 0 ? (n + 1) : totalSum - sum;
            }
            public int MissingNumber(int[] arr)
            {
                int n = arr.Max();
                long totalSum = (long)n * (n + 1) / 2; // Use long for large sums
                long sum = arr.Sum(x => (long)x); // Explicitly convert elements to long during summation
                return (int)(totalSum - sum == 0 ? (n + 1) : totalSum - sum);
            }

        }
    }
}
