using System.Linq;

namespace ArrayDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [3 ,1 ,0 ,4 ,2, 3, 1];
            Solution solution = new Solution();
            (solution.findDuplicates(nums)).ForEach(x => Console.WriteLine(x));
        }
        class Solution
        {
            public List<int> findDuplicates(int[] arr)
            {
                List<int> res = new List<int>();

                Array.Sort(arr);

                for(int i = 0; i <= arr.Length - 1; i++)
                {
                    int firstIndex = i;
                    int lastIndex = BinarySearchLastIndex(arr, arr[i]);

                    if(lastIndex > firstIndex)
                    {
                        res.Add(arr[i]);
                    }
                }

                res.Sort();
                return res;
            }

            public static int BinarySearchLastIndex(int[] nums, int target)
            {
                int l = 0; int r = nums.Length - 1; int lastOccurance = -1;

                while (l <= r)
                {
                    int mid = l + (r - l) / 2;

                    if (nums[mid] == target)
                    {
                        lastOccurance = mid;
                        l = mid + 1;
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

                return lastOccurance;
            }
        }
    }
}
