using Codeabbey.Codeabbey;
using System;

namespace Codeabbey
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter Count");

            S8_ArithmeticProgression.Make(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
