using System;
using System.Linq;

namespace Codeabbey
{
    internal class Program
    {
        private static void Main(string[] args)
        {        
            Console.WriteLine("Enter the number of pairs to count");
            int n = Convert.ToInt32(Console.ReadLine());
            S3.SumsInLoop(n);
        }
    }
}
