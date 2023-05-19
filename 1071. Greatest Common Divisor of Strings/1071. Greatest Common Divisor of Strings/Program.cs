using System;
namespace _1071.Greatest_Common_Divisor_of_Strings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(GcdOfStrings("ABCABC", "ABC"));
        }
        public static string GcdOfStrings(string str1, string str2)
        {
            string result = "";
            if (str1.Length == str2.Length)
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] == str2[i])
                    {
                        if (result.IndexOf(str1[i]) == -1)
                            result += str1[i];
                    }
                }
            
            
            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str2.Length < i)
                        if (str1[i] == str2[i])
                        {
                            if (result.IndexOf(str1[i]) == -1)
                                result += str1[i];
                        }
                       
                }
            }
            if (str1.Length <= str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] == str2[i])
                    {
                        if (result.IndexOf(str1[i]) == -1)
                            result += str1[i];
                    }
                    else if (str2.Length < i)
                    {
                        if (result.IndexOf(str2[i]) == -1)
                            result += str2[i];
                    }
                }
            }



            return result;
        }

    }
    //str1 = "ABCABC", str2 = "ABC"
    public class Solution
    {

    }
}
