namespace SquaresOfSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = [-4 , -2 , 0, 3, 5];
            int[] res = new int[nums.Length];
            

            for(int i = 0; i < nums.Length; i++)
            {
                res[i] = nums[i] * nums[i];
            }

            Array.Sort(res);

            return res;
        }
    }
}
