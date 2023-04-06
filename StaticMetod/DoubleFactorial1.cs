using System;

namespace StaticMetod
{
    internal class DoubleFactorial1
    {
        public static int sum = 1;
        private static void Main()
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
}
