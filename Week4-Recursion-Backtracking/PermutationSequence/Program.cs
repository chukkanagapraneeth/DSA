namespace PermutationSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3, k = 3;
            Solution solution = new Solution();
            Console.WriteLine(solution.GetPermutation(n,k));
        }
        public class Solution
        {
            public string GetPermutation(int n, int k)
            {

                int[] nums = new int[n];

                for (int i = 0; i < n; i++)
                {
                    nums[i] = i+1;
                }

                List<IList<int>> result = new();

                List<int> tempList = new();

                int nCount = nums.Length;

                void BackTrack(List<int> templi)
                {
                    if (templi.Count == nCount)
                    {
                        result.Add(new List<int>(templi));
                        return;
                    }

                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (tempList.Contains(nums[i])) continue;
                        templi.Add(nums[i]);
                        BackTrack(templi);
                        templi.RemoveAt(templi.Count - 1);
                    }
                }

                BackTrack(tempList);

                var arr = result[k - 1];

                string x = String.Join("", arr);

                return x;
            }
        }
    }
}
