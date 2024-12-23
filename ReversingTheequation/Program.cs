namespace ReversingTheequation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = "20-3+5*2";
            Solution solution = new Solution();
            Console.WriteLine(solution.reverseEqn(S));
        }
        class Solution
        {
            //Complete this function
            public string reverseEqn(string s)
            {
                string reverse = "";

                string temp = "";

                foreach(char c in s)
                {
                    if (c == '-' || c == '/' || c == '*' || c == '+')
                    {
                        reverse = c + temp + reverse;
                        temp = "";
                    }
                    else
                    {
                        temp = temp + c;
                    }
                }

                //reverse = temp + reverse;

                return temp + reverse;
            }
        }
    }
}
