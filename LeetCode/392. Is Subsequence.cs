using System;
using System.Diagnostics.Eventing.Reader;

namespace LeetCode
{
    internal class _392
    {
        public static bool IsSubsequence(string s, string t)
        {
            int[] num = new int[s.Length];
            string tmp = "";
            for (int i = 0; i < s.Length; i++)
                for (int j = 0; j < t.Length; j++)
                    if (s[i] == t[j])
                    {
                        if (i == 0)
                        {
                            tmp += t[j];
                            num[i] = j;
                            break;
                        }
                        else
                            for (int k = 0; k < num.Length; k++)
                            {
                                if ((num[k] > j) || (num[k] == j))
                                    break;


                                if (k + 1 >= num.Length)
                                {
                                    tmp += t[j];
                                    num[i] = j;
                                    j = t.Length;
                                    break;
                                }
                            }

                    }

            if (tmp == s)
                return true;

            else return false;
        }
    }
}
