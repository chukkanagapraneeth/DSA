using System.Security.Cryptography;

namespace KthSmallestElementinaSortedMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] nums = [[1, 5, 9], [10, 11, 13], [12, 13, 15]];
            int k = 8;
            Console.WriteLine(solution.KthSmallest(nums, k));

            int[] l = [1, 2, 2, 3];
            Console.WriteLine(Array.LastIndexOf(l,4));
        }
        public class Solution
        {
            public int KthSmallest(int[][] matrix, int k)
            {
                int l = matrix[0][0];
                int r = matrix[^1][^1];

                while(l <= r)
                {
                    int mid = l + (r - l) / 2;

                    int noLessThanK = CountLessThanOrEqual(matrix, mid);
                    int noLessThanKOptimized = CountLessThanOrEqualOptimized(matrix, mid);
                    int noLessThanKIndexOd = CountLessThanOrEqualOptimizedFirstOccurance(matrix, mid);

                    if (noLessThanK < k)
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

            private int CountLessThanOrEqual(int[][] matrix, int target)
            {
                int count = 0;
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] <= target)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                return count;
            }

            private int CountLessThanOrEqualOptimized(int[][] matrix, int target)
            {
                int count = 0;
                int n = matrix.Length;
                int column = n - 1;

                for(int row = 0; row < n; row++)
                {
                    while (column >= 0 && matrix[row][column] > target)
                    {
                        column--;
                    }
                    count += (column + 1);
                }

                return count;
            }

            private int CountLessThanOrEqualOptimizedFirstOccurance(int[][] matrix, int target)
            {
                int count = 0;
                int n = matrix.Length;
                int column = n - 1;

                for (int i = 0; i < n; i++)
                {

                    count += (Array.LastIndexOf(matrix[i], target) + 1);
                    
                }

                return count;
            }
        }
    }
}
