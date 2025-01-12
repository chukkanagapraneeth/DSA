namespace ZigzagGridTraversalWithSkip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            
            Solution solution = new Solution();
            var x = solution.ZigzagTraversal(grid);
        }
        public class Solution
        {
            public IList<int> ZigzagTraversal(int[][] grid)
            {
                List<int> result = new();

                int rows = grid.Length;
                int cols = grid[0].Length;
                int lastElementI = 0;
                for (int i = 0; i < rows; i++)
                {
                    
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < cols; j = j + 2)
                        {
                            result.Add(grid[i][j]);
                            lastElementI = j;
                        }
                    }
                    else
                    {
                        if (lastElementI < cols - 1)
                        {
                            for (int k = cols - 1; k >= 0; k = k - 2)
                            {
                                result.Add(grid[i][k]);
                            }
                        }
                        else
                        {
                            for (int k = cols - 2; k >= 0; k = k - 2)
                            {
                                result.Add(grid[i][k]);
                            }
                        }

                    }
                }
                return result;
            }
        }
    }
}
