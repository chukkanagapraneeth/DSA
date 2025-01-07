namespace SubsetsII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 2];
            Solution solution = new Solution();
            var x = solution.SubsetsWithDup(nums);

        }
        public class Solution
        {
            public IList<IList<int>> SubsetsWithDup(int[] nums)
            {
                List<IList<int>> result = new();
                List<int> tempList = new();

                Array.Sort(nums);

                void BackTrack(int startIndex, List<int> tempLi)
                {
                    result.Add(new List<int>(tempLi));

                    for(int i = startIndex; i < nums.Length; i++)
                    {
                        if(i > startIndex && nums[i] == nums[i - 1])
                        {
                            continue;
                        }

                        tempLi.Add(nums[i]);
                        BackTrack(i + 1, tempLi);
                        tempLi.RemoveAt(tempLi.Count - 1);
                    }
                }

                BackTrack(0, tempList);
                return result;
            }
        }
    }
}
