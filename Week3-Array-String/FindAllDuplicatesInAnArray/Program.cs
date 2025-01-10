namespace FindAllDuplicatesInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [10, 2, 5, 10, 9, 1, 1, 4, 3, 7];
            Solution solution = new Solution();
            solution.FindDuplicates(nums).ToList().ForEach(x => Console.WriteLine(x));
        }
        public class Solution
        {
            public IList<int> FindDuplicates(int[] nums)
            {
                // Thought Process - Main point is questions doesn't mention "Do Not Modify the array." unlike the Find the duplicate number
                // We'll use value of array - 1 as index and update the value of the index with negative value of the current value
                // When we iterate through array we take absolute value

                List<int> res = new List<int>();

                for(int i = 0; i < nums.Length ; i++)
                {
                    int num = nums[Math.Abs(nums[i]) - 1];
                    if (num < 0)
                    {
                        res.Add(Math.Abs(nums[i]));
                    }
                    else
                    {
                        nums[Math.Abs(nums[i]) - 1] = -num;
                    }
                }

                return res;
            }
        }
    }
}
