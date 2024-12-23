namespace SearchinRotatedSortednumsayII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 1, 1, 1, 1, 1, 1, 1, 1, 13, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1];
            int target = 13;
            Solution solution = new Solution();
            Console.WriteLine(solution.Search(nums, target));
        }
        public class Solution
        {
            public bool Search(int[] nums, int target)
            {
                int l = 0;
                int r = nums.Length - 1;

                while (l <= r)
                {
                    int mid = l + (r - l) / 2;
                    if (nums[mid] == target)
                    {
                        return true;
                    }

                    if (nums[l] == nums[mid] && nums[mid] == nums[r])
                    {
                        l++;
                        r--;
                        continue;
                    }
                    if (nums[l] <= nums[mid])
                    {
                        if (nums[l] <= target && target < nums[mid])
                        {
                            r = mid - 1;
                        }
                        else
                        {
                            l = mid + 1;
                        }
                    }
                    else
                    {
                        if (nums[mid] < target && target <= nums[r])
                        {
                            l = mid + 1;
                        }
                        else
                        {
                            r = mid - 1;
                        }
                    }
                }

                return false;
            }
        }
    }
}
