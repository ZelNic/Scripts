using System;
using System.Collections.Generic;

namespace LeetCode
{
    internal class _1207
    {
        public static bool UniqueOccurrences(int[] arr)
        {
            //sorting
            bool sorting = true;
            List<int> list = new List<int>();

            while (sorting == true)
            {
                int n = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i + 1 < arr.Length)
                    {
                        if (arr[i + 1] <= arr[i])
                        {
                            int t = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = t;
                        }
                    }
                }

                for (int j = 0; j < arr.Length; j++)
                {
                    if (j + 1 < arr.Length)
                    {
                        if (arr[j] <= arr[j + 1])
                        {
                            n++;
                        }

                        if (n == arr.Length - 1)
                        {
                            sorting = false;
                        }
                    }
                }
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            return true;
        }
    }
}
