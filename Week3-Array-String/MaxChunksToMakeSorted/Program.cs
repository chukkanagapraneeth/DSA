// Approach 1 - calculate maxtillnow till index i and if max == i then chunk ++

// Approach 2 - calculate running sum and check (n (n + 1))/2, calculate the no of time we get running sum == (n (n + 1))/2 

namespace MaxChunksToMakeSorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 4, 3, 6, 0, 7, 8, 2, 5];
            Solution solution = new Solution();
            Console.WriteLine(solution.MaxChunksToSortedx(arr));
        }
        public class Solution
        {
            // Approach 1
            public int MaxChunksToSorted(int[] arr)
            {
                int chunks = 0;

                int currentHighest = -1;

                for(int i = 0; i < arr.Length; i++)
                {
                    currentHighest = Math.Max(currentHighest, arr[i]);

                    if(currentHighest == i)
                    {
                        chunks++;
                    }
                }

                return chunks;
            }

            // Approach 2
            public int MaxChunksToSortedx(int[] arr)
            {
                int chunks = 0;

                int[] runningSum = new int[arr.Length];
                int[] sumFormula = new int[arr.Length];

                int sumTillNow = 0;

                for(int i = 0; i < arr.Length; i++)
                {
                    sumTillNow += arr[i];
                    runningSum[i] = sumTillNow;

                    sumFormula[i] = (i * (i + 1)/2);
                }

                for(int i = 0;i < arr.Length;i++)
                {
                    if (runningSum[i] == sumFormula[i])
                    {
                        chunks++;
                    }
                }

                return chunks;

            }
        }
    }
}
