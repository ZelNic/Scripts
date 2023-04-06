using System;

namespace StaticMetod
{
    internal class Program
    {
        public static int sum = 1;
        private static void Main()
        {
            Console.WriteLine("Введите число для получения факториала");
            int number = Convert.ToInt32(Console.ReadLine());
            Facrorial(number);
        }

        public static void Facrorial(int value)
        {
            
            if(value == 1) 
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
}
