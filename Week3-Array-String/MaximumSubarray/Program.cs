namespace MaximumSubarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
            Solution solution = new Solution();
            Console.WriteLine(solution.MaxSubArray(nums));
        }
        public class Solution
        {
            // Kadane's Algo - We'll not carry -VE sum as addition of any positive number after that will decrease our sum
            public int MaxSubArray(int[] nums)
            {
                long res = int.MinValue;
                long sum = 0;
                int ansStart = 0; int ansEnd = 0;
                int start = 0;

                for(int i = 0; i < nums.Length; i++)
                {
                    if (sum == 0) start = i;
                    sum += nums[i];

                    if(sum > res)
                    {
                        res = sum;
                        ansStart = start;
                        ansEnd = i;
                    }

                    if(sum < 0)
                    {
                        sum = 0;
                    }
                }

                return (int)res;
            }
        }
    }
}
