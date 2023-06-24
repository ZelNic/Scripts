namespace LeetCode
{
    internal class _283
    {
        public static void MoveZeroes(int[] nums)
        {
            int tmp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[tmp] = nums[i];
                    tmp++;
                }
            }

            while (tmp < nums.Length)
            {
                nums[tmp] = 0;
                tmp++;
            }
        }
    }
}
