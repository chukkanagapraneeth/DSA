using System.Net.Http.Headers;

/*
    THINGS I LEARNT
    1) Cover edge cases seperatly - if nums[0] or nums[^1] is the single element, We can easily avoid index out of bound error this way.
    2) Begin the binary search from l = 1 and r - nums[^2]
    3) To move right or to move left - we have to always move to the side with odd number of numbers.

 */

namespace SingleElementinaSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = [1];
            int[] nums = [1, 2, 2, 3, 3];
            Solution solution = new Solution();
            Console.WriteLine(solution.SingleNonDuplicate(nums));
        }
        public class Solution
        {
            public int SingleNonDuplicate(int[] nums)
            {
                int l = 1;
                int r = nums.Length - 2;

                if (nums[0] != nums[1]) { return nums[0]; }
                if (nums[^1] != nums[^2]) { return nums[^1]; }

                while(l <= r)
                {
                    int mid = l + (r - l) / 2;

                    //return
                    if ((nums[mid] != nums[mid - 1]) && (nums[mid] != nums[mid + 1]))
                    {
                        return nums[mid];
                    }

                    int leftSide = nums[mid - 1] == nums[mid] ? mid - 1 : mid; 

                    if(leftSide % 2 != 0)
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }

                return -1;
            }
        }
    }
}
