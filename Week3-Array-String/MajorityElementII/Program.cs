namespace MajorityElementII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1,2,3,3];
            Solution solution = new Solution();
            (solution.MajorityElement(nums)).ToList().ForEach(x => Console.WriteLine(x));
        }
        public class Solution
        {
            // Using Extended Boyer Moore's Voting Algorithm in Constant Space O(1)
            public IList<int> MajorityElement(int[] nums)
            {              
                List<int> res = new List<int>();

                int count1 = 0, count2 = 0;
                int num1 = int.MinValue, num2 = int.MinValue;

                foreach(int i in nums)
                {
                    if (i == num1)
                    {
                        count1++;
                    }
                    else if (i == num2)
                    {
                        count2++;
                    }
                    else if(count1 == 0)
                    {
                        num1 = i;
                        count1++;
                    }
                    else if(count2 == 0)
                    {
                        num2 = i;
                        count2++;
                    }
                    else
                    {
                        count1--; count2--;
                    }
                }

                count1 = 0;
                count2 = 0;

                foreach(int i in nums)
                {
                    if (i == num1) count1++;
                    if (i == num2) count2++;
                }

                if (count1 > nums.Length / 3) res.Add(num1);
                if (count2 > nums.Length / 3) res.Add(num2);

                return res;

            }

            // Using MAP
            public IList<int> MajorityElement1(int[] nums)
            {
                Dictionary<int, int> dic = new();

                List<int> res = new();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (!dic.ContainsKey(nums[i]))
                    {
                        dic[nums[i]] = 0;
                    }
                    dic[nums[i]] += 1;
                }

                foreach (int key in dic.Keys)
                {
                    if ((dic[key] * 100 / nums.Length) > 33)
                    {
                        res.Add(key);
                    }
                }

                return res;
            }
        }
    }
}
