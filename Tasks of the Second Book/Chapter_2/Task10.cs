using System;

namespace Tasks_of_the_Second_Book.Chapter_2
{
    internal class Task10
    {
        private string _text;
        public Task10(string text) => _text = text;

        internal delegate void MyDelegate10(string text);
        public event MyDelegate10 EventDel;


        public void MethodOne(string text) => Console.WriteLine("Первый метод: " + text);
        public void MethodSecond(string text) => Console.WriteLine("Второй метод: " + text + "Текст переданный при создании объекта класса: " + _text);

        public void RaiseEvent()
        {
            EventDel("Я вызвался!");
            Console.WriteLine();
        }

        public void ActivEventMethodOne()
        {
            Console.WriteLine("Активировался первый event.");
            Console.WriteLine();
        }

        public void ActivEventMethodSecond()
        {
            Console.WriteLine("Активировался второй event.");
            Console.WriteLine();
        }
    }

    public class Task10_DLC
    {
        public void MetodDLC(string text) => Console.WriteLine("Был вызван метод из DLC: " + text + ".");
    }

}
