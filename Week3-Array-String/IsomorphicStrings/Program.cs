//https://leetcode.com/problems/isomorphic-strings/description/
// To Revisit

namespace IsomorphicStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ab"; string d = "aa";
            Solution solution = new Solution();
            Console.WriteLine(solution.IsIsomorphic(s,d));
        }
        public class Solution
        {
            public bool IsIsomorphic(string s, string t)
            {
                // 1) check length if s.Length != t.Length return false
                // 2) count no of letters in both strings
                // 3) IMP ORDER OF CHARACTERS

                if(s.Length != t.Length) { return false; }

                int[] sNo = new int[256];
                int[] tNo = new int[256];

                for(int i = 0; i < s.Length; i++)
                {
                    int scharNo = s[i];
                    int tcharNo = t[i];

                    if (sNo[scharNo] != tNo[tcharNo]) return false;

                    sNo[scharNo] = tNo[tcharNo] = i + 1;
                }

                return true;
            }
        }
    }
}
