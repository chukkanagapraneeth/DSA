namespace CombinationSumII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] candidates = [2, 5, 2, 1, 2]; int target = 5;
            Solution solution = new Solution();
            var x = solution.CombinationSum2(candidates, target);
        }
        public class Solution
        {
            public IList<IList<int>> CombinationSum2(int[] candidates, int target)
            {
                Array.Sort(candidates);
                List<IList<int>> result = new();

                List<int> tempList = new();

                void backTrack(int start, List<int> tempList, int currentTarget)
                {
                    if(currentTarget == 0)
                    {
                        result.Add(new List<int>(tempList));
                        return;
                    }

                    if(currentTarget < 0)
                    {
                        return;
                    }

                    for(int i = start; i < candidates.Length; i++)
                    {
                        if(i > start && candidates[i] == candidates[i - 1])
                        {
                            continue;
                        }

                        tempList.Add(candidates[i]);
                        backTrack(i + 1, tempList, (currentTarget - candidates[i]));
                        tempList.RemoveAt(tempList.Count - 1);
                    }
                }

                backTrack(0, tempList, target);

                return result;
            }
        }
    }
}
