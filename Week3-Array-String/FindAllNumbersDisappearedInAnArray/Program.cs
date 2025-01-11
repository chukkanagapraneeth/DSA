namespace FindAllNumbersDisappearedInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];
            Solution solution = new Solution();
            solution.FindDisappearedNumbers(nums).ToList().ForEach(x => Console.WriteLine(x));
        }
        public class Solution
        {
            public IList<int> FindDisappearedNumbers(int[] nums)
            {

                List<int> result = new();

                for (int i = 0; i < nums.Length; i++)
                {
                    int num = nums[Math.Abs(nums[i]) - 1];
                    if(num > 0)
                    {
                        nums[Math.Abs(nums[i]) - 1] = -num;
                    }
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > 0)
                    {
                        result.Add(i + 1);
                    }
                }

                return result;
            }
        }
    }
}
