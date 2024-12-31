namespace FindTheDuplicateNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 3, 4, 2, 2];
            Solution solution = new Solution();
            Console.WriteLine(solution.FindDuplicate1(nums));
        }
        public class Solution
        {
            // Tortise and Hare Algorithm (Floyd's Cycle Detection Algorithm)

            // Space O(1) - TC O(n^2) BUT WILL GET TLE
            public int FindDuplicate1(int[] nums)
            {
                for(int i = 0; i < nums.Length; i++)
                {
                    for(int j = i + 1; j < nums.Length; j++)
                    {
                        if(nums[i] == nums[j])
                        {
                            return nums[i];
                        }
                    }
                }

                return -1;
            }

            // Using O(n) space and O(n) TC
            public int FindDuplicate2(int[] nums)
            {
                Dictionary<int, int> dic = new();

                foreach (int i in nums)
                {
                    if (dic.ContainsKey(i))
                    {
                        return i;
                    }
                    else
                    {
                        dic[i] = 0;
                    }
                    dic[i] += 1;
                }
                return -1;
            }
        }
    }
}
