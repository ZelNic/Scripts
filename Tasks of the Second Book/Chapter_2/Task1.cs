using System;

namespace Tasks_of_the_Second_Book.Chapter_2
{
    delegate int MyDelegate1(char symbol, string text);
    public class Task2_1_1
    {
        public static int GetCountSymbolInString(char symbol, string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }

        public static int GetIndexSymbolInString(char symbol, string text)
        {
            int index = text.IndexOf(symbol);
            return index;
        }
    }
}
