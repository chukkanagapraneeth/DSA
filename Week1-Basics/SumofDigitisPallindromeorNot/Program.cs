namespace SumofDigitisPallindromeorNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.isDigitSumPalindrome(56));
        }
        class Solution
        {
            //Complete this function
            //Function to check if the sum of digits of a number is palindrome.
            public int isDigitSumPalindrome(int n)
            {
                int sum = 0;

                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }

                string strSum = sum.ToString();
                
                if(strSum.Count() == 1)
                {
                    return 1;
                }
                else
                {
                    int l = 0;
                    int r = strSum.Count() - 1;

                    while (l < r)
                    {
                        if (strSum[l] != strSum[r])
                        {
                            return 0;
                        }
                        else
                        {
                            l++;
                            r--;
                        }
                    }
                    return 1;
                }
            }
        }
    }
}
