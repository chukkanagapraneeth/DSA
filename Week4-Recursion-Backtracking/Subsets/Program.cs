/*

https://leetcode.com/problems/subsets/description/
 
Input: nums = [1,2,3]
Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
 */


namespace Subsets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 3, 4];
            Solution solution = new Solution();
            var x = solution.Subsets(nums);
        }
        public class Solution
        {
            public IList<IList<int>> Subsets(int[] nums)
            {
                //TAKE NOT TAKE Pattern

                List<IList<int>> result = new List<IList<int>>();

                List<int> subArr = new();

                int n = nums.Length;

                void BackTrack(int index, List<int> arr)
                {
                    if(index >= n)
                    {
                        result.Add(new List<int>(arr));
                        return;
                    }

                    // Add first index to subArray
                    arr.Add(nums[index]);

                    // Take
                    BackTrack(index + 1, arr);

                    // Remove first index from subArray
                    arr.RemoveAt(arr.Count - 1);

                    // Not Take
                    BackTrack(index + 1, arr);
                }

                BackTrack(0, subArr);

                return result;
            }
        }
    }
}
