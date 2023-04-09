using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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

    #region нахождение косинуса

    public class TaskClass5
    {
        int a;
        int b;
        int c;
        double cos;
        public void ConsolWrite()
        {
            Console.WriteLine("Здравствуйте, для нахождения косисуна, пожалуйста, введите данные.");
            Console.WriteLine("Введите длину наибольшей стороны треугольника: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину средней стороны треугольника: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длины наименьшей стороны треугольника: ");
            b = Convert.ToInt32(Console.ReadLine());


            cos = (Math.Pow(c, 2) - Math.Pow(a, 2) - Math.Pow(b, 2)) / (-2 * a * b);
        }

        public void ShowResult()
        {
            Console.WriteLine("Косинус равняется: " + cos);
        }
    }

    #endregion

    #region Дискриминант

    public class TaskClass6
    {
        public int a;
        public int b;
        public int c;

        public void ConsolWrite()
        {
            Console.WriteLine("Если уравнение выглядит так ax^2 + bx + c = 0, то заполните данные.");
            Console.WriteLine("Введите значение а.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b.");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение c.");
            c = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowResult()
        {

            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                double Res1 = (-b + Math.Sqrt(D)) / 2 * a;
                double Res2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine($"x_1 = {Res1}.");
                Console.WriteLine($"x_2 = {Res2}.");
            }
            if (D == 0)
            {
                double Res1 = -b / 2 * a;
                Console.WriteLine($"x = {Res1}.");
            }
            else Console.WriteLine("Нет решения.");

        }

    }
    #endregion

    #region TaskClass7
    public class TaskClass7
    {
        private char symbol;



        public void GiveMeChar(char value)
        {
            Symbol = value;
        }

        private char Symbol
        {
            get { return symbol; }
            set
            {
                if (value >= 'A' && value <= 'Z')
                {
                    symbol = value;
                    Console.WriteLine("Данный символ входит в диапазон. Ваш символ:" + Symbol);
                }
                else
                {
                    Console.WriteLine("Данный символ выходит за границы диапазона.");
                }

            }
        }

    }
    #endregion

    #region

    public class CLass8
    {
        private int[] numbers = new int[5] { 0,1,2,3,4};
        private int indx;
        private int _index;

        public void GetIndex()
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public void SetIndex(int value, int ind)
        {
            indx = ind;
            Number = value;
        }

        private int Number
        {
            get 
            {
                return numbers[_index];                
            }
            set 
            {
                numbers[indx] = value;  
                Console.WriteLine();
                Console.WriteLine(numbers[_index]);
                Console.WriteLine();
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }


    }
    #endregion

    public class MyClass
    {
        private static void Main()
        {
            CLass8 class8 = new CLass8();
            class8.GetIndex();            
            class8.SetIndex(99,2);
        }

    }
}
