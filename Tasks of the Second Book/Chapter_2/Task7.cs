using System;

namespace Tasks_of_the_Second_Book.Chapter_2
{
    internal delegate int MyDelegate7(int number);
    internal class Task7
    {        
        public static int StaticMetod(int[] nums, MyDelegate7 del)
        {
            int size = del(4);
            Console.WriteLine(nums[size]);
            return nums[size];
        }
        public static int AnotherMetod(int number)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, number);
            return num;
        }
    }
}
