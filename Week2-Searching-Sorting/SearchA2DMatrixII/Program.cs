//https://leetcode.com/problems/search-a-2d-matrix-ii/description/

// Approach 1 - Loop though each row and do a binary search -  m log n
// Approach 2 - Trick - do a binary search from top right element and if target is less than curent element col-- and if greater than element row++

namespace SearchA2DMatrixII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = [[1, 4, 7, 11, 15], [2, 5, 8, 12, 19], [3, 6, 9, 16, 22], [10, 13, 14, 17, 24], [18, 21, 23, 26, 30]];
            int target = 5;
            Solution solution = new Solution();
            Console.WriteLine(solution.SearchMatrix(matrix, target));

        }
        public class Solution
        {
            public bool SearchMatrix(int[][] matrix, int target)
            {
                int row = 0;
                int column = matrix[0].Length - 1;

                while(column >= 0 && row <= matrix.Length - 1)
                {
                    int currentElement = matrix[row][column];

                    if(currentElement == target)
                    {
                        return true;
                    }
                    else if(target < currentElement)
                    {
                        column--;
                    }
                    else
                    {
                        row++;
                    }
                }
                return false;
            }
        } 
    }
}
