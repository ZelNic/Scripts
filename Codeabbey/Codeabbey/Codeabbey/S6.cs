using System;

namespace Codeabbey
{
    public static class S6
    {
        public static void Rounding(int n)
        {
            if (n == 0) return;

            string s = ""; //enter
            string[] input = s.Split(' ');
            int[] numbers = new int[input.Length];

            Console.WriteLine();

            for (int k = 0; k < numbers.Length; k++)
            {
                numbers[k] = int.Parse(input[k]);
            }

            for (int i = 0; i < numbers.Length; i += 2)
            {
                int num1 = 0;
                int num2 = 0;
                double remainder = 0;


                int intNum = 0;

                for (int j = 0; j < 2; j++)
                {
                    if (j == 0) { num1 = numbers[i + j]; }
                    else if (j == 1) { num2 = numbers[i + j]; }
                }

                intNum = num1 / num2;
                remainder = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                
                if (remainder - intNum == 0.5)
                {
                    if (remainder > 0)
                        remainder += 0.5;

                    if (remainder < 0)
                        remainder -= 0.5;
                }
                Console.WriteLine(Math.Round(remainder));
            }
        }
    }
}
