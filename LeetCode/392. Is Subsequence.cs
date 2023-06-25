using System.Linq;

namespace LeetCode
{
    internal class _392
    {
        public static bool IsSubsequence(string s, string t)
        {
            int numCoincidence = 0;
            for(int i  = 0; i < s.Length; i++)
            {
                for (int j = 0; j < t.Length; j++)
                {
                    if (s[i] == t[j])
                    {
                        numCoincidence++;
                    }
                }
            }
            if (numCoincidence == s.Length)
            {
                return true;
            }
            else return false;
        }
    }
}
