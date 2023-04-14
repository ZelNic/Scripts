using System;
using System.Security.Cryptography.X509Certificates;

namespace Tasks_of_the_Second_Book
{
    public class StartProgramm
    {
        public static void Main()
        {

        }       
    }

    #region Chapter_2

    #region Task_1

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

    #endregion

    #region Task_2

    #endregion


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
    internal interface IInterface
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
    public abstract class Task_4
    {
        protected int num_1;
        protected int num_2;

        public Task_4(int num_1, int num_2)
        {
            this.num_1 = num_1;
            this.num_2 = num_2;
        }
        public abstract int this[int i]
        {
            get;
        }
    }

    internal interface IInterfaceTask_4
    {
        int Metod(int value);
    }

    public class Task_4_1 : Task_4, IInterfaceTask_4
    {
        public Task_4_1(int num_1, int num_2) : base(num_1, num_2)
        {
            this.num_1 = num_1;
            this.num_2 = num_2;
        }

        public override int this[int i]
        {
            get
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Первое число: " + num_1);
                    return num_1;
                }
                else Console.WriteLine("Второе число: " + num_2);
                return num_2;
            }
        }

        public int Metod(int value)
        {
            Console.WriteLine("Ответ: " + num_1 + num_2 * value);
            int sum = num_1 + num_2 * value;
            return sum;
        }
    }

    #endregion

    #region Task_5
    internal interface ITask5
    {
        int Metod(char symbol);
    }

    internal interface ITask5_1
    {
        char Metod(int value);
    }

    public class Task5_1 : ITask5, ITask5_1
    {
        public int Metod(char symbol)
        {
            int i = Convert.ToInt32(symbol);
            Console.WriteLine(i);
            return i;
        }

        public char Metod(int value)
        {
            char s = Convert.ToChar(value);
            Console.WriteLine(s);
            return s;
        }
    }

    #endregion    

    #endregion
}
