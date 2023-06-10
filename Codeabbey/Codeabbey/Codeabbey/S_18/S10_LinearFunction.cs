using System;

namespace Codeabbey.Codeabbey.S_18
{
    //a = (y2 - y1)/(x2 - x1)
    //b = y1 - ax1

    //0 0 1 1
    //1 0 0 1

    //(-43 -196) (2 -140) (60 -291) (-59 882) (16 970) (-30 7) (70 885) (48 -753) (-92 988) (91 436) (-60 232)

    //(-3 -120) (1 -152) (0 420) (1 20) (0 -501) (3 -147) (0 325) (0 614) (0 537) (0 377) (0 -356)

    //    11
    //178 -7850 -654 27926
    //-618 -1376 -770 -1680
    //988 58989 420 24909
    //179 -9679 199 -10859
    //-934 -13974 -501 -7046
    //-156 4687 -615 18457
    //-689 -47345 325 23635
    //781 36735 614 28719
    //-748 69804 537 -48416
    //-702 -63446 377 34743
    //581 -34628 -356 21592

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
