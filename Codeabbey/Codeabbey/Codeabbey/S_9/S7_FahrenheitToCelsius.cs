using System;

namespace Codeabbey.Codeabbey
{
    public class S7_FahrenheitToCelsius
    {
        public static void FahrenheitToCelsius(int n)
        {            
            string s = "171 537 292 499 570 578 363 572 165 492 298 140 332 426 155 125 138 48 167 457 160 92 567 343 45 77 238 255 193 494 543 187 83";            
            string[] arrStrT;
            arrStrT = s.Split(' ');

            int[] valueT = new int[arrStrT.Length];

            for (int k = 0;  k < arrStrT.Length; k++)
            {
                valueT[k] = Convert.ToInt32(arrStrT[k]);
            }

            for (int i = 0; i < valueT.Length; i++)
            {
                Console.WriteLine(Convert.ToInt32((valueT[i] - 32) / 1.8));
            }

        }
    }
}
////Фаренгейт — 32) : 1,8 = Цельсий 