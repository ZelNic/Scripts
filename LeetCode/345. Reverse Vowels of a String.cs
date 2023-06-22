using System;
using System.Reflection;

namespace LeetCode
{

    public static class _345
    {
        public static string ReverseVowels(string s)
        {
            char[] chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string tmp = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                for (int x = 0; x < chars.Length; x++)
                {
                    if (s[i] == chars[x])
                        tmp += s[i];
                }
            }

            for (int j = 0; j < s.Length; j++)
            {
                for (int x = 0; x < chars.Length; x++)
                {
                    if (s[j] == chars[x])
                    {
                        for (int k = 0; k < tmp.Length; k++)
                        {
                            s = s.Remove(j, 1).Insert(j, tmp[k].ToString());
                            tmp = tmp.Remove(k, 1);
                            break;
                        }
                        break;
                    }
                }
            }
            return s;
        }
    }
}
