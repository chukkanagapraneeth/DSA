namespace CombinationSumIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 4, n = 1;
            Solution solution = new Solution();
            var x = solution.CombinationSum3(k, n);
        }
        public class Solution
        {
            public IList<IList<int>> CombinationSum3(int k, int n)
            {
                List<IList<int>> result = new();

                List<int> tempList = new();

                void BackTrack(int startingNumber, List<int> tempList, int currentTarget)
                {
                    if (tempList.Count == k && currentTarget == 0)
                    {
                        result.Add(new List<int>(tempList));
                        return;
                    }

                    if (startingNumber > currentTarget || startingNumber > n)
                    {
                        return;
                    }

                    for (int i = startingNumber; i <= 9; i++)
                    {
                        tempList.Add(i);
                        BackTrack(i + 1, tempList, currentTarget - i);
                        tempList.RemoveAt(tempList.Count - 1);
                    }
                }

                BackTrack(1, tempList, n);
                return result;
            }
        }
    }
}
