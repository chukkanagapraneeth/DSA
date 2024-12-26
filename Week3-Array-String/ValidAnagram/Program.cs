// https://leetcode.com/problems/valid-anagram/description/

// Approach 1 - use 2 dictionaries to track chars and frequencies. Loop through both dic and return false if frequencies don't match

// Approach 2 - use an array of 26 size (only small letters) and loop through s and add 1 to each occurance of letter
//              then loop through t and subtract for each occurance. If arr consists 0 in all places return true else false

namespace ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "anagram"; string t = "nagaram";
            Solution solution = new Solution();
            Console.WriteLine(solution.IsAnagramOptimized(s,t));
        }
        public class Solution
        {
            public bool IsAnagram(string s, string t)
            {
                if (s.Length != t.Length) return false;

                Dictionary<char, int> sDic = new();
                Dictionary<char, int> tDic = new();

                for (int i = 0; i < s.Length; i++)
                {
                    if (!sDic.ContainsKey(s[i]))
                    {
                        sDic[s[i]] = 0;
                    }
                    sDic[s[i]]++;

                    if (!tDic.ContainsKey(t[i]))
                    {
                        tDic[t[i]] = 0;
                    }
                    tDic[t[i]]++;
                }

                foreach (char cc in s)
                {
                    if (!tDic.ContainsKey(cc)) return false;
                    if (sDic[cc] != tDic[cc]) return false;
                }

                return true;
            }

            public bool IsAnagramOptimized(string s, string t)
            {
                if (s.Length != t.Length) return false;

                int[] res = new int[26];

                foreach(char c in s)
                {
                    int indexToUpdate = (int)c - 97; // 97 ascii for lowercase a
                    res[indexToUpdate]++;
                }

                foreach (char c in t)
                {
                    int indexToUpdate = (int)c - 97; // 97 ascii for lowercase a
                    res[indexToUpdate]--;
                }

                foreach(int i in res)
                {
                    if (i != 0) return false;
                }

                return true;
            }
        }
    }
}
