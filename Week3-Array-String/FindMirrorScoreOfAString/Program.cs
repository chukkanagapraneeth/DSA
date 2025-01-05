namespace FindMirrorScoreOfAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "aczzx";
            Solution solution = new Solution();
            Console.WriteLine(solution.CalculateScore(s));
        }
        public class Solution
        {
            public long CalculateScore(string s)
            {
                Dictionary<char, List<int>> dic = new();

                int totalScore = 0;

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (!dic.ContainsKey(s[i]))
                    {
                        dic[s[i]] = new List<int>();
                    }
                    dic[s[i]].Add(i);
                }

                for (int j = 1; j < s.Length; j++)
                {

                    char currentChar = s[j];
                    char reversedChar = (char)('z' - (currentChar - 'a'));

                    if (!dic.ContainsKey(reversedChar) || dic[reversedChar].Count == 0)
                    {
                        continue;
                    }


                    int closestIndex = -1;

                    for (int i = 0; i < dic[reversedChar].Count; i++)
                    {
                        if (dic[reversedChar][i] < j)
                        {
                            closestIndex = dic[reversedChar][i];
                            dic[reversedChar].RemoveAt(i);
                            dic[currentChar].Remove(j);
                            break;
                        }
                    }

                    if (closestIndex == -1) continue;
                    totalScore += (j - closestIndex);
                }
                return totalScore;
            }
        }
    }
}
