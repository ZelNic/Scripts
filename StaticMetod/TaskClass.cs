using System;

namespace StaticMetod
{
    public class TaskClass
    {
        int a;
        int b;

        public TaskClass()
        {
            a = 1;
            b = 2;
        }

        public TaskClass(int a)
        {
            this.a = a;
            b = 3;
        }

        public TaskClass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Show()
        {
            Console.WriteLine($"a: {a}, b: {b}");
        }
    }


    public class TaskClass2
    {
        public char A = 'A';
        public char D = 'Z';

        public void BetweenChar()
        {
            for(int i = 'A';  i < 'Z' + 1 ;  i++)
            {
                Console.WriteLine(Convert.ToChar(i));
            }
        }
    }


    public class MyClass
    {        
        static void Main()
        {
            TaskClass2 tc = new TaskClass2();
            tc.BetweenChar();
        }

    }
}
