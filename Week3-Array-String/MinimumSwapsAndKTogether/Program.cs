//https://www.geeksforgeeks.org/problems/minimum-swaps-required-to-bring-all-elements-less-than-or-equal-to-k-together4847/1

// initial thought process - NOT SLIDING WINDOW
// get the indexes of all nos <= k
// count the differences between each consecutive number and if the difference is greater than 1 then count++
// Not the correct solution cuz it doensn't calculate min no's as A X B Y C -> Y X B A C needs 1 swap but my sol shows 2 -------- NAHHHH
// Made changes to include this scenario A X B Y C -> Y X B A C  - Here swap is only 1 in scenarios where A X B Y C or A X B Y C W D V E where A -> E are smaller elemets than k and their count is always 2, 4 , 6 etc..
// My Solution fails at this test case arr = [7, 6, 1, 4, 8, 3, 2], k = 4 which is not there in gfg... Better go with Sliding window.

// Sliding Window MAKES more SENSE

namespace MinimumSwapsAndKTogether
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [7, 6, 1, 4, 8, 3, 2]; int k = 4;
            Solution solution = new Solution();
            Console.WriteLine(solution.minSwap(arr,k));
        }
        class Solution
        {
            // SLIDING WINDOW
            public int minSwap(int[] arr, int k)
            {
                // need to decide window size - which would be no of elements <= k
                // to check bad elements in each window - no of bad elements == no of swaps we can make
                // find the window with less no of swaps and return it. Viola!

                // Window size is no of elements <= K
                int windowSize = 0;
                foreach(int i in arr)
                {
                    if(i > k) windowSize++;
                }

                // Initialize sliding window 
                int badElements = 0;
                for(int i = 0; i < windowSize; i++)
                {
                    if (arr[i] > k) badElements++;
                }

                int minSwaps = badElements;

                for(int i = 0, j = windowSize; j < arr.Length; i++, j++)
                {
                    if (arr[i] > k) badElements--;
                    if (arr[j] > k) badElements++;

                    minSwaps = Math.Min(minSwaps, badElements);
                }

                return minSwaps;
            }

            // MY SOLUTION ATTEMPT
            public int  minSwap_mine(int[] arr, int k)
            {
                int count = 0;
                int recent = -1;
                int prevDifference = 0;
                int prevDiffCount = 0;

                for(int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] <= k)
                    {
                        if(i - recent != 1)
                        {
                            if(prevDifference == 2 && prevDiffCount == 2)
                            {
                                prevDifference = 0;
                                prevDiffCount = 0;
                                count--;
                            }
                            prevDifference = i - recent;
                            prevDiffCount++;
                            count++;
                        }
                        recent = i;
                    }
                }

                return count;
            }
        }
    }
}
