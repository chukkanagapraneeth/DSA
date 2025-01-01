namespace PowerOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 16;
            Solution solution = new Solution();
            Console.WriteLine(solution.IsPowerOfTwo(n));
        }
        public class Solution
        {
            public bool IsPowerOfTwo(int n)
            {
                if (n == 1) return true;
                if (n <= 0) return false;
                return RecuHelper(n);
            }
            public bool RecuHelper(int n)
            {
                if (n == 1) return true;
                if (n % 2 == 1 && n != 2)
                {
                    return false;
                }

                return RecuHelper(n / 2);
            }
        }
    }
}
