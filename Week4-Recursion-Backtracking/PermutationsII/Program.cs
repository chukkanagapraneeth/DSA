namespace PermutationsII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1];
            Solution solution = new Solution();
            var x = solution.PermuteUnique(nums);
        }
        public class Solution
        {
            public IList<IList<int>> PermuteUnique(int[] nums)
            {
                Dictionary<int, int> dic = new();
                int n = nums.Length;
                List<int> keys = new();

                foreach (int i in nums)
                {
                    if (!dic.ContainsKey(i))
                    {
                        dic[i] = 0;
                        keys.Add(i);
                    }
                    dic[i]++;
                }

                List<IList<int>> result = new();
                List<int> tempList = new();

                void BackTrack(int startIndex, List<int> templi)
                {
                    if (templi.Count == n)
                    {
                        result.Add(new List<int>(templi));
                        return;
                    }

                    for(int i = startIndex; i < keys.Count; i++)
                    {
                        if (dic[keys[i]] == 0) continue;
                        templi.Add(keys[i]);
                        dic[keys[i]]--;
                        BackTrack(startIndex, templi);
                        templi.RemoveAt(templi.Count - 1);
                        dic[keys[i]]++;
                    }
                }

                BackTrack(0, tempList);
                return result;
            }
        }
    }
}
