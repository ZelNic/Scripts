using System;
using System.Collections.Generic;

namespace LeetCode
{
    internal class _2215
    {
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            List<int> awn1 = new List<int>();
            List<int> awn2 = new List<int>();
            IList<IList<int>> full = new List<IList<int>>();
            int bLength;
            int mLength;

            if (nums1.Length > nums2.Length || nums1.Length == nums2.Length)
            {
                bLength = nums1.Length;
                mLength = nums2.Length;
            }
            else
            {
                bLength = nums2.Length;
                mLength = nums1.Length;
            }

            for (int i = 0; i < bLength; i++)
            {
                bool coincidence1 = false;
                bool coincidence2 = false;

                for (int j = 0; j < mLength; j++)
                {
                    
                        if (nums1[i] == nums2[j])
                            coincidence1 = true;

                        if (coincidence1 == false && j + 1 >= mLength)
                            if (!awn1.Contains(nums1[i]))
                                awn1.Add(nums1[i]);


                    
                        if (nums2[i] == nums1[j])
                            coincidence2 = true;

                        if (coincidence2 == false && j + 1 >= mLength)
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



//else
//{
//    if (i < nums1.Length)
//        if (!awn1.Contains(nums1[i]))
//            awn1.Add(nums1[i]);

//    if (i < nums2.Length)
//        if (!awn2.Contains(nums2[i]))
//            awn2.Add(nums2[i]);
//}