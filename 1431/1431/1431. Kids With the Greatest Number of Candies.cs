using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    public class _1431
    {
        public List<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> result = new List<bool>();

            int max = candies.Max();
            foreach (int cand in candies)
            {
                if (cand + extraCandies >= max)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
            }

            return result;
        }
    }
}
