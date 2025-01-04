namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] candidates = [2, 3, 5]; int target = 8;
            Solution solution = new Solution();
            var x = solution.CombinationSum(candidates, target);
        }
        public class Solution
        {
            public IList<IList<int>> CombinationSum(int[] candidates, int target)
            {
                List<IList<int>> result = new();

                int n = candidates.Length;

                List<int> tempArr = new();

                void BackTrack(int index, List<int> tempArr, int currentTarget)
                {
                    
                    if(currentTarget == 0)
                    {
                        result.Add(new List<int>(tempArr));
                        return;
                    }

                    if(currentTarget < 0)
                    {
                        return;
                    }

                    for(int i = index; i < n; i++)
                    {
                        tempArr.Add(candidates[i]);
                        BackTrack(i, tempArr , (currentTarget - candidates[i]));
                        tempArr.RemoveAt(tempArr.Count - 1);
                    }

                    // If we do not want to use for loop then we can do this

                    /*
                    if (currentTarget < 0 || index >= n)
                    {
                        return;
                    }

                    tempArr.Add(candidates[index]);
                    BackTrack(index, tempArr, (currentTarget - candidates[index]));
                    tempArr.RemoveAt(tempArr.Count - 1);
                    BackTrack(index + 1, tempArr, currentTarget);
                    */
                }

                BackTrack(0, tempArr, target);
                return result;
            }
        }
    }
}
