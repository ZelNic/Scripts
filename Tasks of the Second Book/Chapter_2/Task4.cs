using System;

namespace Tasks_of_the_Second_Book.Chapter_2
{
    internal delegate int MyDelegate4(int k);
    internal class Task4
    {         
        public MyDelegate4 this[int i]
        {
            get 
            {
                MyDelegate4 del = delegate (int k)
                {
                    return (int)Math.Pow(k, i);
                };
                return del;
            }
        }
    }
}

