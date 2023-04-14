namespace Tasks_of_the_Second_Book.Chapter_2
{
    internal delegate int MyDelegate5();
    internal class Task5
    {
        public static int x = 1;
        public static int y = 1;
        public static int z;
        public MyDelegate5 del = () => { z = x; x += y; y = z; return x; };
        public int Fibonachy()
        {
            {
                for (int i = 0; i < 10; i++)
                {
                    z = x;
                    x += y;
                    y = z;
                }
                return x;
            }
        }
    }
}
