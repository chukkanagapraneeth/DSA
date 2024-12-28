namespace SearchA2DMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = [[1]];
            int k = 0;
            Solution solution = new Solution();
            Console.WriteLine(solution.SearchMatrix(matrix, k));
        }
        public class Solution
        {
            public bool SearchMatrix(int[][] matrix, int target)
            {
                int l = 0;
                int r = (matrix.Length * matrix[0].Length) - 1;

                while(l <= r)
                {
                    int mid = l + (r - l) / 2;

                    if (matrix[mid / matrix[0].Length][mid % matrix[0].Length] == target)
                    {
                        return true;
                    }
                    else if(matrix[mid / matrix[0].Length][mid % matrix[0].Length] > target)
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
                return false;
            }
        }
    }
}
