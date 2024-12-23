namespace CountDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.evenlyDivides(12));
        }
        class Solution
        {
            public int evenlyDivides(int n)
            {

                int count = 0;

                var arr = n.ToString().ToCharArray();
                foreach(var i in arr)
                {
                    if((int)Char.GetNumericValue(i) == 0)
                    {
                        continue;
                    }
                    if(n % ((int) i - '0') == 0)
                    {
                        count++;
                    }
                }

                return count;

            }
        }
    }
}
