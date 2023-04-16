using System;
using System.Collections.Generic;

namespace Tasks_of_the_Second_Book.Chapter_3
{
    internal class _3Task1
    {
        enum Days : byte
        {
            Понедельник, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье
        }

        Dictionary<string, int> dict = new Dictionary<string, int>();
        int a;
        int b;
        public void Today()
        {
            Days[] days = (Days[])Enum.GetValues(typeof(Days));            
            for (int i = 0; i < days.Length; i++)            
            {                
                dict.Add(days[i].ToString(), i);
            }

            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine(kvp.Key + " Значение: " + kvp.Value);
                dict.TryGetValue("Вторник", out int value);
                dict.TryGetValue("Воскресенье", out int value_2);
                a = value;
                b = value_2;
            }
        }

        public void DaysBetween()
        {
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine("-------------------");
            Console.WriteLine(b - a);
        }
    }
}
