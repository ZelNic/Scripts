using System;

namespace Leetcode
{
    public static class _605
    {
        public class Solution
        {
            public bool CanPlaceFlowers(int[] flowerbed, int n)
            {
                if (n == 0) return true;

                if (flowerbed.Length == 1)
                {
                    if (flowerbed[0] == 0)
                    { return true; }
                }

                for (int i = 0; i < flowerbed.Length; i++)
                {
                    if (i == 0)
                    {
                        if ((flowerbed[i] == 0) && (flowerbed[i + 1] == 0))
                        {
                            n--;
                            flowerbed[i] = 1;
                            if (n == 0)
                            {
                                return true;
                            }
                        }
                    }

                    if (i + 1 < flowerbed.Length)
                    {
                        if ((flowerbed[i] == 0) && (flowerbed[i + 1] == 0) && (i + 1 == flowerbed.Length - 1))
                        {
                            flowerbed[i + 1] = 1;
                            n--;

                            if ((n == 0) && (i + 1 == flowerbed.Length - 1))
                            {
                                return true;
                            }
                        }

                        if ((flowerbed[i] == 0) && (flowerbed[i + 1] == 0 && flowerbed[i - 1] == 0))
                        {
                            n--;
                            flowerbed[i] = 1;
                            if (n == 0)
                            {
                                return true;
                            }
                        }
                    }

                    if (i + 1 >= flowerbed.Length)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
