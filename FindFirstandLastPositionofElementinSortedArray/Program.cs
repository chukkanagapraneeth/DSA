/*
 Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

If target is not found in the array, return [-1, -1].

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [5,7,7,8,8,10], target = 8
Output: [3,4]
Example 2:

Input: nums = [5,7,7,8,8,10], target = 6
Output: [-1,-1]
Example 3:

Input: nums = [], target = 0
Output: [-1,-1]
 */

namespace FindFirstandLastPositionofElementinSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [];
            int target = 6;
            Solution solution = new Solution();
            (solution.SearchRange(nums, target)).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;

            int[] res = new int[] {-1, -1};

            if(nums.Length == 0)
            {
                return res;
            }

            while(l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] == target)
                {
                    res[0] = mid;
                    r = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            if (res[0] == -1)
            {
                return res;
            }

            l = res[0];
            r = nums.Length - 1;

            while(l <= r)
            {
                int mid2 = l + (r - l) / 2;
                if(mid2 == l)
                {
                    l = mid2 + 1;
                }
                if (nums[mid2] == target)
                {
                    res[1] = mid2;
                    l = mid2 + 1;
                }
                else
                {
                    r = mid2 - 1;
                }
            }

            return res;
        }
    }
}
