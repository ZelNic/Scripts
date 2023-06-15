namespace _1431
{
    public class _1431
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[0] == 0)
                {
                    if ((flowerbed[i] == 0) && (flowerbed[i + 1] == 0))
                    {
                        if (n == 0)
                        {
                            return true;
                        }
                        n--;
                    }
                    else return false;
                }
                else if (flowerbed[0] == 1)
                {
                    if ((flowerbed[i] == 1) )
                    {
                        continue''
                    }
                }                
            }
            return true;
        }
    }

}
