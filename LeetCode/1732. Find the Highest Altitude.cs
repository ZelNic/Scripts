using System;
using System.Collections.Generic;

namespace LeetCode
{
    internal class _1732
    {
        public static int LargestAltitude(int[] gain)
        {
            int altitude = 0;
            int t = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                if (i == 0)
                {
                    if (gain[i] < 0)
                    {
                        t = t + gain[i];                        
                    }
                    else
                    {
                        t = gain[i] - t;                       
                    }
                }
                else
                {
                    if (t > gain[i])
                    {
                        t = t + gain[i];
                    }
                    else
                    {
                        t = gain[i] + t;
                    }
                }

                if(t > altitude)
                {
                    altitude = t;
                }
            }

            return altitude;
        }
    }
}
