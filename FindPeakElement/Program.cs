namespace FindPeakElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [6, 5, 4, 3, 2, 3, 2];
            Solution solution = new Solution();
            Console.WriteLine(solution.FindPeakElement(nums));
        }
        public class Solution
        {
            public int FindPeakElement(int[] nums)
            {
                int l = 0;
                int r = nums.Length - 1;

                while (l <= r)
                {
                    int mid = l + (r - l) / 2;

                    if (l == mid)
                    {
                        if (nums[mid] > nums[r])
                        {
                            return mid;
                        }
                        else
                        {
                            return r;
                        }
                    }

                    if (nums[mid] > nums[mid + 1] && nums[mid] > nums[mid - 1])
                    {
                        return mid;
                    }

                    if (nums[mid - 1] > nums[mid])
                    {
                        r = mid - 1;
                    }
                    else if (nums[mid + 1] > nums[mid])
                    {
                        l = mid + 1;
                    }
                }
                return -1;
            }
        }
    }
}
