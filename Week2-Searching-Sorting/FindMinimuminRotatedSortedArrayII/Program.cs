namespace FindMinimuminRotatedSortedArrayII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [2, 2, 2, 0, 1];
            Solution solution = new Solution();
            Console.WriteLine(solution.FindMin(nums));
        }
        public class Solution
        {
            public int FindMin(int[] nums)
            {
                int l = 0;
                int r = nums.Length - 1;
                int lowest = int.MaxValue;

                while (l <= r)
                {
                    int mid = l + (r - l) / 2;
                    if (nums[l] == nums[mid])
                    {
                        l++;
                        continue;
                    }
                    if (nums[mid] == nums[r])
                    {
                        r--;
                        continue;
                    }

                    if (nums[l] <= nums[mid])
                    {
                        lowest = Math.Min(lowest, nums[l]);
                        l = mid + 1;
                    }
                    else if (nums[mid] <= nums[r])
                    {
                        lowest = Math.Min(lowest, nums[mid]);
                        r = mid - 1;
                    }
                }

                return lowest;
            }
        }
    }
}
