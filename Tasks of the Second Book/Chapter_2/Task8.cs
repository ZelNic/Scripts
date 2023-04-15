using System;

namespace Tasks_of_the_Second_Book.Chapter_2
{
    internal delegate int MyDelegate8(int number);
    internal class Task8
    {
        internal static MyDelegate8 MetodWithDelegate(MyDelegate8 metod, MyDelegate8 metod_2)
        {            
            MyDelegate8 sum = metod + metod_2;            
            return sum;
        }

        public static int Number_1(int number)
        {
            return number * 2;
        }

        public static int Number_2(int number)
        {
            return number + 2;
        }

        /* main  MyDelegate8 del = Task8.Number_1;                
            MyDelegate8 del2 = Task8.Number_2; 
            MyDelegate8 sum = Task8.MetodWithDelegate(del, del2);
            int result = sum(5);
            Console.WriteLine(result);*/
    }
}
