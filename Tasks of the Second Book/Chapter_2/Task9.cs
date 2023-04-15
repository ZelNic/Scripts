namespace Tasks_of_the_Second_Book.Chapter_2
{
    internal delegate double MyDelegate9(double x);
    internal class Task9
    {
        public static MyDelegate9 Quadratic(double a, double b, double c)
        {
            return (double x) => a * x + x * b + x * c;
        }
    }
}