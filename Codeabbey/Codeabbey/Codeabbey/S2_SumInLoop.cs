using System.Linq;

namespace Codeabbey
{
    public static class S2_SumInLoop
    {
        public static int SumInLoop(string s)
        {
            string str = s;
            int[] array = s.Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            foreach (int i in array)
                sum += i;

            return sum;
        }
    }
}
