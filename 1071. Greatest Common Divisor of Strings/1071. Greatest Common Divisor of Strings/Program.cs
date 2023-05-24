using System;

namespace _1071.Greatest_Common_Divisor_of_Strings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(GcdOfStrings("ABCA", "ABCABAC"));
        }
        public static string GcdOfStrings(string str1, string str2)
        {
            string result = "";
            for (int i = 0; i < str1.Length; i++)
            {
                if ((str1.Length > i) && (str2.Length > i))
                    if (str1[i] == str2[i])
                        if (result.IndexOf(str1[i]) == -1)
                            result += str1[i];


                if ((str1.Length > i) && (str2.Length <= i))
                    for (int j = i; j < str1.Length; j += str2.Length)
                    {
                        for (int k = 0; k < str2.Length; k++)
                            if (str1[j + k] == str2[k]) continue;
                            else return result = "";

                        return result;
                    }


                if ((str1.Length <= i) && (str2.Length > i))
                    for (int j = i; j < str2.Length; j+= str1.Length)
                    {
                        for (int k = 0; k < str1.Length; k++)
                            if (str2[j + k] == str1[k]) continue;
                            else return result = "";

                        return result;
                    }
            }
            return result;
        }
    }
}
// if ((result.Length >= 1) && (result[result.Length - 1] == str1[j])) result += str1[i];\

//for (int j = 0; j < str1.Length; j++)
//{
//    if (str1[j] == result.IndexOf(str2[j])) continue;
//    else if (str1[j] != result.IndexOf(str2[j]))
//    {
//        return result = "";
//    }
//    return result;
//}