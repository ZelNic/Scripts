using System;

namespace Tasks_of_the_Second_Book.Chapter_3
{
    internal struct _3Task2
    {
        int number;
        string text;
        char symbol;

        public _3Task2(int number, string text, char symbol)
        {
            this.number = number;
            this.text = text;
            this.symbol = symbol;
        }

        public _3Task2(int number, string text)
        {
            this.number = number;
            this.text = text;
            symbol = '1';
        }
        public _3Task2(int number)
        {
            this.number = number;
            text = "text";
            symbol = '2';
        }

        public void ShowData()
        {
            Console.WriteLine($"Цифра: " + number + " Текст: " + text + " Символ: " + symbol + ".");
        }
    }
}
