using System.Collections.Generic;
using System;

namespace LeetCode
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            Solution_1480 solution_1480 = new Solution_1480();
            solution_1480.RunningSum(nums);

        }
    }

    public class Solution_1480
    {
        public int[] RunningSum(int[] nums)
        {
            int[] temp = new int[nums.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                if (i == 0)
                {
                    temp[i] += nums[i];
                }
                if (i > 0)
                {
                    temp[i] += nums[i] + temp[i - 1];
                }  
            }
            nums = temp;            
            return nums;
        }
    }

    #region 9. Palindrome
    public class Solution_9
    {
        public bool IsPalindrome(int x)
        {
            string number = Convert.ToString(x);
            string temp = null;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                temp += number[i];
            }
            if (temp == number)
            {
                Console.WriteLine("Palindrome");
                return true;
            }
            else
                return false;
        }
    }
    #endregion

    #region  1. Two Sum
    public class Solution_1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int y = target - nums[i];
                if (dict.ContainsKey(y))
                {
                    return new int[] { dict[y], i };
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }
            throw new Exception("Not found.");
        }
    }
    #endregion
}
