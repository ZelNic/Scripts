using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class _1207
    {
        public static bool UniqueOccurrences(int[] arr)
        {
            //sorting
            bool sorting = true;
            Dictionary<int, int> d = new Dictionary<int, int>();

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

            for (int k = 0; k < arr.Length; k++)
            {
                if (k == 0)
                {
                    d.Add(arr[k], 1);
                    continue;
                }

                if (d.ContainsKey(arr[k]))
                {
                    d[arr[k]] += 1;
                }
                else
                {
                    d.Add(arr[k], 1);
                }
            }

            if (d.Values.Distinct().Count() == d.Count)
            {
                Console.WriteLine("Все значения ключей уникальны");
                return true;
            }
            else
            {
                Console.WriteLine("Есть повторяющиеся значения ключей");
                return false;
            }
        }
    }
}
