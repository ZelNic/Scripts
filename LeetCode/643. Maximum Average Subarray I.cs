using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class _643
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            double sumAve = 0;
            double max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < i + k; j++)
                {
                    if (j < nums.Length)
                    {
                        sumAve += nums[j];

                        if (j + 1 >= i + k)
                        {
                            sumAve /= k;

                            if (i == 0)                            
                                max = sumAve;
                            
                            else if (sumAve > max)                            
                                max = sumAve;
                            
                            sumAve = 0;
                        }
                    }
                }
            }
            return max;
        }
    }
}
