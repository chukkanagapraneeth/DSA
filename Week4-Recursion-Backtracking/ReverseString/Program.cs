// https://leetcode.com/problems/reverse-string/

// Approach 1 - two pointer while loop

// Approach 2 - Recursion using 2 pointer

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] s = ['h', 'e', 'l', 'l', 'o'];
            Solution solution = new Solution();
            solution.ReverseString(s);
            s.ToList().ForEach(x => Console.WriteLine(x));
        }
        public class Solution
        {
            public void ReverseString(char[] s)
            {
                int l = 0;
                int r = s.Length - 1;

                RecuHelper(s, l, r);

            }

            public void RecuHelper(char[] s, int l, int r)
            {
                if (l > r)
                {
                    return;
                }
                char temp = s[l];
                s[l] = s[r];
                s[r] = temp;

                l++;
                r--;

                RecuHelper(s, l, r);
            }
        }
    }
}
