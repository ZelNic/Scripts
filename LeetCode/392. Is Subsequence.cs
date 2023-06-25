using System.Linq;

namespace LeetCode
{
    internal class _392
    {
        public static bool IsSubsequence(string s, string t)
        {
            string tmp = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < t.Length; j++)
                {
                    if (s[i] == t[j])
                    {
                        tmp += t[j];
                    }
                }
            }
            if (tmp == s)
            {
                return true;
            }
            else return false;
        }
    }
}
