namespace FindTheDuplicateNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 3, 4, 2, 2];
            Solution solution = new Solution();
            Console.WriteLine(solution.FindDuplicateBuffer(nums));
        }
        public class Solution
        {
            // Tortise and Hare Algorithm (Floyd's Cycle Detection Algorithm)
            public int FindDuplicate(int[] nums)
            {
                int slow = 0, fast = 0, n = nums.Length;

                while (true)
                {
                    slow = nums[slow];
                    fast = nums[nums[fast]];
                    if (slow == fast) break;
                }

                int slow2 = 0;

                while (true)
                {
                    slow = nums[slow];
                    slow2 = nums[slow2];
                    if(slow == slow2) break;
                }

                return slow;
            }

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

            //buffer
            public int FindDuplicateBuffer(int[] nums)
            {
                var lenght = nums.Length;
                var buffer = new bool[lenght];
                foreach (var num in nums)
                {
                    if (buffer[num])
                    {
                        return num;
                    }
                    buffer[num] = true;
                }
                return 0;
            }
        }
    }
}
