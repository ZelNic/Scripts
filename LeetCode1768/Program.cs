
//Input: word1 = "abc", word2 = "pqr"
//Output: "apbqcr"
//Explanation: The merged string will be merged as so:
//word1: a b   c
//word2:    p q   r
//merged: a p b q c r

using System;

namespace LeetCode1768
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(MergedString("abc", "pqr"));
        }

        private static string MergedString(string one, string two)
        {
            string sum = "";
            if (one.Length == two.Length)
                for (int i = 0; i < one.Length; i++)
                {
                    sum += one[i];
                    sum += two[i];
                }
            if (one.Length > two.Length)
                for (int i = 0; i < one.Length; i++)
                {
                    sum += one[i];
                    if (two.Length > i)
                        sum += two[i];
                }
            if (one.Length < two.Length)
                for (int i = 0; i < two.Length; i++)
                {
                    if (one.Length > i)
                        sum += one[i];
                    sum += two[i];
                }

            return sum;
        }

    }


}
