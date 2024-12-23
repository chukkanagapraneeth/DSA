namespace ArmstrongNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.armstrongNumber(1553));
        }
        class Solution
        {
            public bool armstrongNumber(int n)
            {
                string num = n.ToString();
                int sum = 0;

                foreach(char i in num)
                {
                    sum += (int)Math.Pow(((int)i - '0'), 3);
                }

                List<int> s = new List<int>();
                s.Add

                return sum == n;

            }
        }
    }
}
