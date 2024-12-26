/*
 * Good Problem, need to revisit
 * https://leetcode.com/problems/roman-to-integer/description/
 */

namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "MCMXCIV";
            Solution solution = new Solution();
            Console.WriteLine(solution.RomanToInt(s));
        }
        public class Solution
        {
            public int RomanToInt(string s)
            {
                Dictionary<char, int> dic = new Dictionary<char, int>();
                dic['I'] = 1;
                dic['V'] = 5;
                dic['X'] = 10;
                dic['L'] = 50;
                dic['C'] = 100;
                dic['D'] = 500;
                dic['M'] = 1000;

                int sum = 0;
                int prev = 0;
                
                for(int i = s.Length -1; i >= 0; i--)
                {
                    int curr = dic[s[i]];

                    int m = (curr < prev) ? -1 : 1;

                    sum += curr * m;
                    prev = curr;
                }

                return sum;
            }
        }
    }
}
