using System.Collections.Generic;
using System;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace LeetCode
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] nums = { 1, 7, 3, 6, 5, 6 };
            Solution_724 solution_724 = new Solution_724();
            solution_724.PivotIndex(nums);

        }
    }
    #region 724. Find Pivot Index
    public class Solution_724
    {
        public int PivotIndex(int[] nums)
        {
            int leftSum = 0;
            int rightSum = nums.Skip(1).Sum();
            if (leftSum == rightSum) return 0;
            for (int i = 1; i < nums.Length; i++)
            {
                leftSum += nums[i - 1];
                rightSum -= nums[i];
                if (leftSum == rightSum) return i;
            }
            return -1;
        }
    }


    #endregion


    #region 1480. Running Sum of 1d Array
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
    #endregion

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
