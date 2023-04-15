using System;

namespace Tasks_of_the_Second_Book.Chapter_2
{
    internal delegate string MyDelegate6();

    internal class Task6
    {
        public static string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        public MyDelegate6 del = () =>
        {
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
                Console.ReadKey();
                if (i == days.Length - 1)
                {
                    i = -1;
                }                
            }
            return null;
        };

    }
}
