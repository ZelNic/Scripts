
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Tasks_of_the_Second_Book
{
    public class StartProgramm
    {
        public static void Main()
        {
        }
    }



    #region Chapter_1

    #region Task_1

    public abstract class Task_1
    {
        protected int[] array;
        private int sizeArray;

        public int SizeArray
        {
            get { return sizeArray; }
            set
            {
                sizeArray = value;
            }
        }
        public int this[int i]
        {
            get { return i; }
            set { array[i] = value; }
        }
        public void Method()
        {

        }
        public Task_1(int sizeArray)
        {
            array = new int[sizeArray];
        }
    }

    public class Task_1_1 : Task_1
    {
        public Task_1_1(int sizeArray) : base(sizeArray)
        {
            array = new int[sizeArray];
        }

        public new void Method()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }


    #endregion

    #region Task_2
    public abstract class Task_2
    {
        protected string text;

        public Task_2(string text) { }

        public abstract int Number { get; }

        public abstract int this[int i] { get; }

        public abstract void Method(string text);
        public abstract void Method_2();
    }

    public class Task_2_1 : Task_2
    {
        public Task_2_1(string text) : base(text)
        {
            this.text = text;
        }

        public override int this[int i]
        {
            get { return text[i]; }
        }

        public override int Number { get { return text.Length; } }

        public override void Method(string text)
        {
            this.text = text;
        }

        public override void Method_2()
        {
            Console.WriteLine(text);
        }
    }
    #endregion

    #region Task_3
    interface IInterface
    {
        int Method();
    }

    public class Task_3 : IInterface
    {
        private int countNumber;
        private int sum;

        public Task_3(int countNumber)
        {
            this.countNumber = countNumber;           
        }

        public int Method()
        {
            for (int i = 0; i < countNumber; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }     
            }
            Console.WriteLine("Сумма четных чисел: " + sum);
            return sum;
        }
    }

    public class Task_3_1 : IInterface
    {
        private int countNumber;
        private int sum;

        public Task_3_1(int countNumber)
        {
            this.countNumber = countNumber;
        }


        public int Method()
        {
            for (int i = 0; i < countNumber; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }               
            }
            Console.WriteLine("Сумма нечетных чисел: " + sum);
            return sum;
        }
    }
    #endregion

    #region Task_4


    #endregion

    #endregion
}
