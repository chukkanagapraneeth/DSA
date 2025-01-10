namespace RestoreIPAddresses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "101023";
            Solution solution = new Solution();
            var x = solution.RestoreIpAddresses(s);
        }
        public class Solution
        {
            public IList<string> RestoreIpAddresses(string s)
            {
                List<string> result = new List<string>();

                void BackTrack(int idx, string currentString, int noOfDotsUsed)
                {
                    if(noOfDotsUsed == 3)
                    {
                        string lastSegment = s.Substring(idx);
                        if (IsValidSegment(lastSegment))
                        {
                            result.Add(currentString + lastSegment);
                        }
                        return;
                    }


                    for(int i = 1; i <= 3; i++)
                    {
                        if (idx + i > s.Length) break;

                        string subString = s.Substring(idx, i);

                        if (!IsValidSegment(subString)) continue;

                        BackTrack(idx + i, currentString + subString + ".", noOfDotsUsed + 1);
                    }
                }

                BackTrack(0, "", 0);
                return result;
            }

            private bool IsValidSegment(string segment)
            {
                if (string.IsNullOrEmpty(segment)) return false;
                if (segment.Length > 1 && segment.StartsWith('0')) return false;
                if (int.Parse(segment) > 255) return false;
                return true;
            }
        }
    }
}
