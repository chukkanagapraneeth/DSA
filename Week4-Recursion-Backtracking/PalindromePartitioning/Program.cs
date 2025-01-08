namespace PalindromePartitioning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "aab";
            Solution solution = new Solution();
            var x = solution.Partition(s);
        }
        public class Solution
        {
            public IList<IList<string>> Partition(string s)
            {
                List<IList<string>> result = new();

                List<string> tempList = new();

                void BackTrack(int idx, List<string> currentPartition)
                {
                    if(idx == s.Length)
                    {
                        result.Add(new List<string>(currentPartition));
                        return;
                    }

                    for(int i = idx; i < s.Length; i++)
                    {
                        if (IsPalindrome(s, idx, i))
                        {
                            currentPartition.Add(s.Substring(idx, i - idx + 1));
                            BackTrack(i + 1, currentPartition);
                            currentPartition.RemoveAt(currentPartition.Count - 1);
                        }
                    }
                }

                BackTrack(0, tempList);
                return result;

            }

            private bool IsPalindrome(string s, int start, int end)
            {
                while(start < end)
                {
                    if (s[start] != s[end]) return false;
                    start++;
                    end--;
                }
                return true;
            }
        }
    }
}
