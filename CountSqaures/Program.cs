namespace CountSqaures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.countSquares(10));
        }
        class Solution
        {
            // Complete this function
            public int countSquares(int n)
            {
                var floored = Math.Floor(Math.Sqrt(n));

                int compare = floored.CompareTo(Math.Sqrt(n));

                if (compare == 0)
                {
                    return Convert.ToInt32(floored) - 1;
                }
                else
                {
                    return Convert.ToInt32(floored);
                }
            }
        }
    }
}
