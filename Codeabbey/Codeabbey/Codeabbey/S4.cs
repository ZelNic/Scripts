using System;

namespace Codeabbey
{
    public static class S4
    {
        public static void MinimumOfTwo(int n)
        {
            if (n == 0) return;

            string container = "";
            int[] ar1 = new int[n];
            int[] ar2 = new int[n];
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                string wrStr = Console.ReadLine();

                int delimiter = wrStr.IndexOf(' ');
                if (delimiter == -1) continue;

                for (int j = 0; j < delimiter; j++)
                {
                    container += wrStr[j];
                }
                ar1[i] = Convert.ToInt32(container);
                container = "";

                for (int j = ++delimiter; j < wrStr.Length; j++)
                {
                    container += wrStr[j];
                }
                ar2[i] = Convert.ToInt32(container);
                container = "";
            }

            Console.WriteLine();

            for (int k = 0; k < n; k++)
            {
                if (ar1[k] < ar2[k])
                {
                    result[k] = ar1[k];
                    Console.WriteLine(result[k]);
                }
                if (ar1[k] > ar2[k])
                {
                    result[k] = ar2[k];
                    Console.WriteLine(result[k]);
                }
                else if (ar1[k] == ar2[k])
                {
                    Console.WriteLine("Equelly numbers.");
                }


            }
        }
    }
}
