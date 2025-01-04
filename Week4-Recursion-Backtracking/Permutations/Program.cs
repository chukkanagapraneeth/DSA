namespace Permutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [0,1];
            Solution solution = new Solution();
            var x = solution.Permute(nums);

        }
        public class Solution
        {
            public IList<IList<int>> Permute(int[] nums)
            {
                List<IList<int>> result = new();

                List<int> tempList = new();

                int n = nums.Length;

                void BackTrack(List<int> templi)
                {
                    if(templi.Count == n)
                    {
                        result.Add(new List<int>(templi));
                        return;
                    }

                    for(int i = 0; i < nums.Length; i++)
                    {
                        if (tempList.Contains(nums[i])) continue;
                        templi.Add(nums[i]);
                        BackTrack(templi);
                        templi.RemoveAt(templi.Count - 1);
                    }
                }

                BackTrack(tempList);
                return result;
            }
        }
    }
}
