namespace BinaryWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class Solution
        {
            public IList<string> ReadBinaryWatch(int turnedOn)
            {
                var result = new List<string>();
                var leds = new int[10]; // 4 LEDs for hours, 6 LEDs for minutes
                Backtrack(result, leds, turnedOn, 0);
                return result;

                
            }

            private void Backtrack(List<string> result, int[] leds, int turnedOn, int index)
            {
                // Base case: if no more LEDs to turn on
                if (turnedOn == 0)
                {
                    int hour = 0, minute = 0;

                    // Calculate hours and minutes from the LED array
                    for (int i = 0; i < 4; i++)
                    {
                        if (leds[i] == 1) hour += (1 << i);
                    }
                    for (int i = 4; i < 10; i++)
                    {
                        if (leds[i] == 1) minute += (1 << (i - 4));
                    }

                    // Validate and format the result
                    if (hour < 12 && minute < 60)
                    {
                        result.Add($"{hour}:{minute:D2}");
                    }
                    return;
                }

                // If we run out of LEDs to turn on, return
                if (index == leds.Length) return;

                // Option 1: Turn on the current LED
                leds[index] = 1;
                Backtrack(result, leds, turnedOn - 1, index + 1);

                // Option 2: Do not turn on the current LED
                leds[index] = 0;
                Backtrack(result, leds, turnedOn, index + 1);
            }
        }
    }
}
