using System;

namespace StaticMetod
{
    #region SquaresSum
    public class SquaresSum
    {
        public static int sum = 0;
        public static void WriteCon()
        {
            Console.WriteLine("Введите число для нахождения суммы квадратов");
            int number = Convert.ToInt32(Console.ReadLine());
            SumSquares(number);
        }

        public static void SumSquares(int value)
        {
            if (value == 1)
            {
                sum += value;
                Console.WriteLine(sum);
            }
            if (value > 1)
            {
                double temp = Math.Pow(value, 2);
                sum += Convert.ToInt32(temp);
                SumSquares(value - 1);
            }
        }
    }
    #endregion

    #region DoubleFactorial
    public class DoubleFactorial
    {
        public static int sum = 1;
        private static void WriteCon()
        {
            Console.WriteLine("Введите число для получения факториала");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                FacrorialEven(number);
            }
            else FacrorialOdd(number);
        }
        public static void FacrorialEven(int value)
        {

            if (value == 1)
            {
                sum *= value;
                Console.WriteLine("Ответ: " + sum);
            }
            if (value > 1)
            {
                int temp = value * 1;
                if (temp % 2 == 0)
                {
                    sum *= temp;
                    FacrorialEven(value - 1);
                }
                else FacrorialEven(value - 1);
            }
        }

        public static void FacrorialOdd(int value)
        {

            if (value == 1)
            {
                sum *= value;
                Console.WriteLine("Ответ: " + sum);
            }
            if (value > 1)
            {
                int temp = value * 1;
                if (temp % 2 == 1)
                {
                    sum *= temp;
                    FacrorialOdd(value - 1);
                }
                else FacrorialOdd(value - 1);
            }

        }
    }
    #endregion

    #region Factorial
    public class Factorial
    {
        public static int sum = 1;
        private static void WriteCon()
        {
            Console.WriteLine("Введите число для получения факториала");
            int number = Convert.ToInt32(Console.ReadLine());
            Facrorial(number);
        }

        public static void Facrorial(int value)
        {

            if (value == 1)
            {
                sum *= value;
                Console.WriteLine("Ответ: " + sum);
            }
            if (value > 1)
            {
                int temp = value * 1;
                sum *= temp;
                Facrorial(value - 1);
            }

        }
    }
    #endregion

    #region TaskClass
    public class TaskClass
    {
        private int a;
        private int b;

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
    #endregion

    #region TaskClass2
    public class TaskClass2
    {
        public char A = 'A';
        public char D = 'Z';

        public void BetweenChar()
        {
            for (int i = 'A'; i < 'Z' + 1; i++)
            {
                Console.WriteLine(Convert.ToChar(i));
            }
        }
    }
    #endregion

    #region TaskClass3 // преобразование вещ.числа в символ
    public class TaskClass3
    {
        public int number;
        public char b;

        public TaskClass3(double value)
        {
            string temps = Convert.ToString(value);
            int index = temps.IndexOf(',');
            if (index != -1)
            {
                number = Convert.ToInt32(temps.Substring(index + 1));
            }

            int temp = Convert.ToInt32(value / 1);
            b = Convert.ToChar(temp);

        }

        public void WriteCon()
        {
            Console.WriteLine("Введите вещественное число");
            double value = Convert.ToDouble(Console.ReadLine());
            TaskClass3 c = new TaskClass3(value);
            c.ShowCon();
        }

        public void ShowCon()
        {

            Console.WriteLine($"Остаток от введенного числа: {number}, целое число соответствует символу: {b}");
        }
    }
    #endregion // п

    #region MinMaxAverageParams
    public class MinMaxAverageParams
    {
        private int maxNumber;
        private int minNumber;
        private int averageNumbers;
        private int sum;
        public void GiveMeNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Array.Sort(numbers);
                minNumber = numbers[0];
                maxNumber = numbers[numbers.Length - 1];

                sum = +numbers[i];
            }
            averageNumbers = sum / numbers.Length;
        }

        public void ShowCon()
        {
            Console.WriteLine("Наибольшее число: " + maxNumber);
            Console.WriteLine("Наименьшнее число: " + minNumber);
            Console.WriteLine("Среднее число: " + averageNumbers);
        }

        public void InsertMeInMain()
        {
            MinMaxAverageParams t = new MinMaxAverageParams();
            Console.WriteLine("Введите числа для нахождения наибольшего, наименьшего и среднего чисел");
            string input = Console.ReadLine();
            string[] m_string = input.Split(' ');
            int[] ints = new int[m_string.Length];
            for (int i = 0; i < m_string.Length; i++)
            {
                ints[i] = Convert.ToInt32(m_string[i]);
            }
            t.GiveMeNumbers(ints);
            t.ShowCon();
        }

    }
    #endregion



    public class MyClass
    {
        private static void Main()
        {

        }

    }
}
