//https://www.geeksforgeeks.org/problems/equilibrium-point-1587115620/1

// Intution - Get all the left sum in one array, right sum in another array. Loop through each index of both array and if both values
// are same then return that index.

// Intution 2 - To reduce the space complexity, we can take only one array and minus the right sum and the index where it's 0 return it.

// Intution 3 - Just count total sum and keep Leftsum = 0, rSum = totalsum and each iteration calculate rsum - arr[i] and compare ls == rs.


namespace EquilibriumPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,3,5,2,2 };
            Solution solution = new Solution();
            Console.WriteLine(solution.equilibriumPoint(arr));
        }
        class Solution
        {
            // Function to find equilibrium point in the array.
            public int equilibriumPoint(int[] arr)
            {
                int totalSum = 0;

                for(int i = 0; i < arr.Length; i++)
                {
                    totalSum += arr[i];
                }

                int lSum = 0; int rSum = totalSum;

                for(int i = 0; i < arr.Length;i++)
                {
                    rSum -= arr[i];
                    if(lSum == rSum)
                    {
                        return i + 1;
                    }
                    lSum += arr[i];
                }

                return -1;
            }
        }

    }
}
