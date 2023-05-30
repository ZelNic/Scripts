using System;

namespace Codeabbey
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.SetBufferSize(1000,1000);
            Console.WriteLine("Enter the number of pairs to count");            
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Beep();
            
            S6.Rounding(n);
        }
    }
}
