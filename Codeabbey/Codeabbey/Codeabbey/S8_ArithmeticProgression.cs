using System;

namespace Codeabbey.Codeabbey
{
    public class S8_ArithmeticProgression
    {
        public static void Make(int A)
        {
            if (A == 0) return;

            string s = "";

            string[] input = s.Split(' ');
            int[] numbers = new int[input.Length];

            Console.WriteLine();

            for (int k = 0; k < numbers.Length; k++)
            {
                numbers[k] = int.Parse(input[k]);
            }

            for (int i = 0; i < numbers.Length; i += 3)
            {
                int a = 0;
                int b = 0;
                int c = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (j == 0) { a = numbers[i + j]; }
                    else if (j == 1) { b = numbers[i + j]; }
                    else if (j == 2) { c = numbers[i + j]; }
                }

                if ((a < b) && (a < c)) { Console.WriteLine(a); }
                if ((b < c) && (b < a)) { Console.WriteLine(b); }
                if ((c < a) && (c < b)) { Console.WriteLine(c); }
            }
        }
    }
    }
}
