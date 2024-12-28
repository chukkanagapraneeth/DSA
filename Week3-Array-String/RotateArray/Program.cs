// https://leetcode.com/problems/rotate-array/description/


namespace RotateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1,2,3]; int k = 4;
            Solution solution = new Solution();
            solution.Rotate(nums, k);
            nums.ToList().ForEach(x => Console.WriteLine(x));
        }
        public class Solution
        {
            // O(1) 
            public void Rotate(int[] nums, int k)
            {
                k = k % nums.Length;

                Reverse(nums, 0, nums.Length - 1);
                Reverse(nums, 0, k - 1);
                Reverse(nums, k , nums.Length - 1);
            }

            public void Reverse(int[] nums, int start, int end)
            {
                while(start < end)
                {
                    int temp = nums[start];
                    nums[start] = nums[end];
                    nums[end] = temp;
                    start++;
                    end--;
                }
            }

            // Using Extra Memory and O(N)
            public void Rotate2(int[] nums, int k)
            {
                int[] doubleNums = new int[nums.Length * 2];

                Array.Copy(nums, 0, doubleNums, 0, nums.Length);
                Array.Copy(nums, 0, doubleNums, nums.Length, nums.Length);

                int startIndex = nums.Length - (k % nums.Length);

                Array.Copy(doubleNums, startIndex, nums, 0, nums.Length);
            }
        }
    }
}
