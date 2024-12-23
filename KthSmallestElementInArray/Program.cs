/*
 * This is magic, somehow the algo always converges to a number present in array.
 * Key Learning #1: Leverage Binary Search for Range-Based Problems
    Why: If the problem involves finding an element based on a count, position, or property within a range (like the Kth smallest), binary search can often be applied.
    How:
    Define the range (l and r), typically starting from the minimum and maximum possible values of the problem.
    Use mid to test whether the current candidate satisfies the required condition (like counting elements less than or equal to mid).
 * Key Learning #2: Binary Search Can Work on Answers, Not Just Indexes
    Why: Binary search is not just for searching elements in sorted arrays but also for searching over a possible range of answers when the solution can be described in terms of a condition.
 * Key Learning #8: Generalize to Other Problems
    Why: Many problems share this pattern of "find the Xth something," and the same binary search intuition applies.
    Examples of Similar Problems:
    Median of Two Sorted Arrays: Binary search on the smaller array.
    Split Array Largest Sum: Binary search on the possible range of sums.
    Kth Smallest Element in a Sorted Matrix: Binary search on value range using count.
    Aggressive Cows / Allocate Minimum Pages: Binary search on range of distances/pages.
 */


namespace KthSmallestElementInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [0,10,20];
            int k = 2;
            Solution solution = new Solution();
            Console.WriteLine(solution.FindKthSmallestElement(nums, k));
        }
        public class Solution
        {
            public int FindKthSmallestElement(int[] nums, int k)
            {
                int l = nums.Min();
                int r = nums.Max();

                while(l <= r)
                {
                    int mid = l + (r - l) / 2;

                    int noOfDigitsLessThanK = 0;

                    for(int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] <= mid)
                        {
                            noOfDigitsLessThanK++;
                        }
                    }

                    if(noOfDigitsLessThanK < k)
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        r = mid - 1;
                    }
                }

                return l;
            }
        }
    }
}
