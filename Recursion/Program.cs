using System;
using System.Collections.Generic;

namespace Recursion
{
    internal class Program
    {
        private static int total;
        public static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 4 };
            Sum(numbers);
        }

        public static int Sum(List<int> numbers)
        {
            if (numbers.Count == 1)
            {
                total += numbers[0];
                Console.WriteLine(total);
                return total;
            }
            else
            {
                total += numbers[numbers.Count - 1];
                if (numbers.Count != 1)
                {
                    numbers.RemoveAt(numbers.Count - 1);
                }
                Sum(numbers);

                return total;
            }
        }
    }
}
