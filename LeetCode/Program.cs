using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
   
    #region 205. Isomorphic Strings
    public class Solution_205
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            if (s.Length != t.Length) return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]) && dict.TryGetValue(s[i], out char value) && value == t[i])
                    continue;
                if (!dict.ContainsKey(s[i]) && !dict.ContainsValue(t[i]))
                    dict.Add(s[i], t[i]);
                if (dict.ContainsKey(s[i]) && dict.TryGetValue(s[i], out char val) && val != t[i])                
                    return false;                
                if (dict.ContainsKey(s[i]) && !dict.ContainsValue(t[i]) || !dict.ContainsKey(s[i]) && dict.ContainsValue(t[i]))
                    return false;
            }
            return true;
        }
    }
    #endregion

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


