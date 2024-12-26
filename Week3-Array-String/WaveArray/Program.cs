/*
 * https://www.geeksforgeeks.org/problems/wave-array-1587115621/1?track=amazon-arrays&batchId=192
 * 
 */

namespace WaveArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = [1,2,3,4,5];
            Solution solution = new Solution();
            solution.convertToWave(x);
            x.ToList().ForEach(ele => Console.WriteLine(ele));
        }
        class Solution
        {
            public void convertToWave(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i =  i + 2)
                {
                    int temp;
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
        }

    }
}
