namespace MaximumNestingDepthoftheParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "(1+(2*3)+((8)/4))+1" , "()(())((()()))"
            string s = "(1)+((2))+(((3)))";
            Solution solution = new Solution();
            Console.WriteLine(solution.MaxDepth(s));
        }
        public class Solution
        {
            public int MaxDepth(string s)
            {
                int max = 0;
                int temp = 0;
                foreach (char c in s)
                {
                    if (c == '(')
                    {
                        temp++;
                        max = Math.Max(max, temp);
                    }
                    else if (c == ')')
                    {
                        temp--;
                    }
                }

                return max;
            }
        }
    }
}
