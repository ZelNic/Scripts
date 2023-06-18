using System;
using System.Linq;

namespace Leetcode
{
    internal class _344
    {
        public static void ReverseString(char[] s)
        {
            string tmp = "";
            int index = s.Length - 1;           

            for (int i = s.Length - 1; i >= 0; i--)
            {               
                tmp += s[i];                                         
            }
            Console.WriteLine(tmp);
        }
    }
}
