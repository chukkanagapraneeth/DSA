// Print 1 to n using backtracking without using +
// Print n to 1 using backtracking

namespace BackTrackingBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackTracking1toN(3,3);
            BackTrackingNto1(1,3);
        }

        public static void BackTracking1toN(int i, int n)
        {
            if (i < 1) return;

            BackTracking1toN(i - 1, n);

            Console.WriteLine(i);
        }

        public static void BackTrackingNto1(int i, int n)
        {
            if(i > n) return;
            BackTrackingNto1(i + 1, n);
            Console.WriteLine(i);
        }
    }
}
