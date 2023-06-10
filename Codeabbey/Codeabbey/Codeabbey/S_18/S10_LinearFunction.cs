using System;

namespace Codeabbey.Codeabbey.S_18
{
    //a = (y2 - y1)/(x2 - x1)
    //b = y1 - ax1

    //0 0 1 1
    //1 0 0 1

    

    public static class S10_LinearFunction
    {
        public static void Make(int countExample)
        {
            if (countExample == 0) return;

            Console.WriteLine("Enter nubmers.");
            string s = Console.ReadLine();

            string[] input = s.Split(' ');
            int[] numbers = new int[input.Length];

            Console.WriteLine();

            for (int k = 0; k < numbers.Length; k++)
            {
                numbers[k] = int.Parse(input[k]);
            }

            for (int i = 0; i < numbers.Length; i += 4)
            {
                int x1 = 0;
                int x2 = 0;
                int y1 = 0;
                int y2 = 0;

                for (int j = 0; j < 4; j++)
                {
                    if (j == 0) { x1 = numbers[i + j]; }
                    else if (j == 1) { x2 = numbers[i + j]; }
                    else if (j == 2) { y1 = numbers[i + j]; }
                    else if (j == 3) { y2 = numbers[i + j]; }
                }
                int a = 0;
                
                try
                {
                    a = (y2 - y1) / (x2 - x1);
                }
                catch
                {
                    a = 0;
                }

                int b = y1 - a * x1;

                Console.Write($"({a} {b}) ");
            }
            Console.WriteLine();
        }
    }
}
