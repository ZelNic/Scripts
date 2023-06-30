using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class _643
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            double sum = 0;
            double sumAve = 0;
            double max = 0;
            int startPoint = 0;
            int endPoint = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                    for (int j = i; j < i + k; j++)
                    {
                        sum += nums[j];

                        if (j + 1 >= i + k)
                        {
                            endPoint = j;
                            sumAve = sum;

                            sumAve /= k;
                            max = sumAve;

                        }
                    }
                else
                {
                    if (endPoint + 1 < nums.Length)
                    {
                        endPoint++;
                        sum -= nums[startPoint];
                        sum += nums[endPoint];
                        sumAve = sum;

                        startPoint++;

                        if (endPoint + 1 < nums.Length)
                            endPoint++;

                        sumAve /= k;

                    }


                    if (sumAve > max)
                        max = sumAve;

                }
            }
            return max;
        }
    }
}


//if (j < nums.Length)
//{
//    sumAve += nums[j];

//    if (j + 1 >= i + k)
//    {
//        sumAve /= k;

//        if (i == 0)
//            max = sumAve;

//        else if (sumAve > max)
//            max = sumAve;

//        sumAve = 0;
//    }
//}