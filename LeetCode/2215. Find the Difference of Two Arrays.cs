using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _2215
    {
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            List<int> awn1 = new List<int>();
            List<int> awn2 = new List<int>();
            IList<IList<int>> full = new List<IList<int>>();


            for (int i = 0; i < nums1.Length; i++)
            {
                bool coincidence = false;

                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                        coincidence = true;

                    if (coincidence == false && j + 1 >= nums2.Length)
                        if (!awn1.Contains(nums1[i]))
                            awn1.Add(nums1[i]);
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                bool coincidence = false;

                for (int j = 0; j < nums1.Length; j++)
                {
                    if (nums2[i] == nums1[j])
                        coincidence = true;

                    if (coincidence == false && j + 1 >= nums1.Length)
                        if (!awn2.Contains(nums2[i]))
                            awn2.Add(nums2[i]);
                }
            }


            full.Add(awn1);
            full.Add(awn2);

            foreach (var list in full)
            {
                foreach (var num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            return full;
        }
    }
}