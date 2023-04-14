using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_of_the_Second_Book.Chapter_2
{
    delegate int MyDelegate4(int k);
    internal class Task4
    {
        public MyDelegate4 del;
        public MyDelegate4 this[int i]
        {
            get { return this[i]; }
        }

        public int ReturnInt(int i)
        {
            int result;
            return result = (int)Math.Pow(i, (int)this[i]);
        }

        

    }
}

