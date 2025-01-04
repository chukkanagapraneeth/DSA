using System.Collections.Immutable;

// Need to revisit, good BT problem

namespace Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var x = solution.Combine(4, 2);
        }
        public class Solution
        {
            public IList<IList<int>> Combine(int n, int k)
            {
                List<IList<int>> result = new();

                List<int> res = new();
                void backTrack(int start, List<int> combination)
                {
                    if(combination.Count == k)
                    {
                        result.Add(new List<int>(combination));
                        return;
                    }

                    for(int i = start; i <= n; i++)
                    {
                        combination.Add(i);
                        backTrack(i + 1, combination);
                        combination.RemoveAt(combination.Count - 1);
                    }
                }

                backTrack(1, res);
                return result;
            }
        }
    }
}
