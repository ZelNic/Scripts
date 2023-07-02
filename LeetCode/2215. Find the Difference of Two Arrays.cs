using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class _2215
    {
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            List<int> awn1 = new List<int>();
            List<int> awn2 = new List<int>();
            IList<IList<int>> full = new List<IList<int>>();


            ///Добавить проверку на длину массивов.


            for (int i = 0; i < nums1.Length; i++)
            {
                bool coincidence1 = false;
                bool coincidence2 = false;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        coincidence1 = true;
                    }

                    if (nums2[i] == nums1[j])
                    {
                        coincidence2 = true;
                    }

                    if (coincidence1 == false && j + 1 >= nums2.Length)
                    {
                        if (!awn1.Contains(nums1[i]))
                        {
                            awn1.Add(nums1[i]);
                        }
                    }

                    if (coincidence2 == false && j + 1 >= nums2.Length)
                    {
                        if (!awn2.Contains(nums2[i]))
                        {
                            awn2.Add(nums2[i]);
                        }
                    }
                }
            }

            full.Add(awn1);
            full.Add(awn2);

            foreach (IList<int> list in full)
            {
                foreach (int number in list)
                {
                    Console.WriteLine(number);
                }
            }


            return full;
        }
    }
}
