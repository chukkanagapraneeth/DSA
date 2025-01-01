/*
Observations To Make
1) if OpenBrackerCount == ClosedBracketCount then only option is to add 'C'
2) We'll only add string to result list when both open and close count == 0
3) 
*/

namespace GenerateParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.GenerateParenthesis(2).ToList().ForEach(x => Console.WriteLine(x));

        }
        public class Solution
        {
            public IList<string> GenerateParenthesis(int n)
            {
                List<string> result = new List<string>();
                string s = "";
                randFunction(0, 0, s, n, result);
                return result;
            }
            public static void randFunction(int openBracketNo, int closedBracketNo, string currentString, int n, List<string> result)
            {
                if(openBracketNo == n && closedBracketNo == n)
                {
                    result.Add(currentString);
                    return;
                }

                if(openBracketNo < n)
                {
                    randFunction(openBracketNo + 1, closedBracketNo, currentString + '(', n, result);
                }

                if(closedBracketNo < openBracketNo)
                {
                    randFunction(openBracketNo, closedBracketNo + 1, currentString + ')', n, result);
                }
            }
        }
    }
}
