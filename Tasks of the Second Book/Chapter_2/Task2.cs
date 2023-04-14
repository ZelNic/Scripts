using System;

namespace Tasks_of_the_Second_Book.Chapter_2
{
    internal delegate void MyDelegate2(char symbol);

    /*public static Task2[] arrayTask2 = new Task2[10];

     void Main_()
    {
        for (int i = 0; i < arrayTask2.Length; i++)
        {
            arrayTask2[i] = new Task2();
        }

        MyDelegate2 myDelegate2 = new MyDelegate2(arrayTask2[0].SetSymbol);

        for (int i = 1; i < arrayTask2.Length; i++)
        {
            myDelegate2 += arrayTask2[i].SetSymbol;
        }

        myDelegate2('s');

        for (int i = 1; i < arrayTask2.Length; i++)
        {
            arrayTask2[i].GetSymbol();
        }

    }*/


    internal class Task2
    {
        private char _symbol;

        public void GetSymbol()
        {
            Console.WriteLine(_symbol);
        }

        public void SetSymbol(char symbol)
        {
            _symbol = symbol;           
        }



    }


}
