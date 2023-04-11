using System;
using System.Collections.Generic;

namespace StaticMetod
{
    public class Test
    {
        private static void Main()
        {
            int[] nums = { 3, 2, 3 };
            Solution solution = new Solution();
            solution.TwoSum(nums, 6);

        }
    }

    #region Задача с LeetCode. Two Sum.
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();      

            for (int i = 0; i < nums.Length; i++)
            {
                int y = target - nums[i];
                if (dict.ContainsKey(y))
                {
                    return new int[] { dict[y], i };
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }
            throw new Exception("Not found.");
        }  
    }


    /*public int[] TwoSum(int[] nums, int target)
        {
            while (search)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    sum = 0;
                    sum += nums[i];                    
                    xI = Array.IndexOf(nums, nums[i]);
                    int startIndex = xI;
                    for (int j = 0; j < nums.Length; j++)
                    {
                        yI = Array.IndexOf(nums, nums[j]);
                        if (yI == xI)
                        {
                            yI = Array.IndexOf(nums, nums[j], startIndex++);
                        }
                        if (yI != xI)
                        {
                            if (sum + nums[j] == target)
                            {       
                                int[] array = new int[] { xI, yI };
                                Console.WriteLine($"{xI},{yI}");
                                search = false;
                                return array;
                            }
                        }
                    }
                }
            }
            return null;
        }*/


    #endregion

    #region Задания с наследованиеями 
    #region Наследование с использованием ToString();
    public class Alpha
    {
        private string text;

        public Alpha(string text)
        {
            this.text = text;
        }

        public virtual void ToString()
        {
            Console.WriteLine("Alpha -  " + text);
        }
    }

    public class Bravo : Alpha
    {
        private string text2;
        private string text3;
        public Bravo(string text2) : base(text2)
        {
            this.text2 = text2;
        }


        public Bravo(string text2, string text3) : base(text2)
        {
            this.text2 = text2;
            this.text3 = text3;
        }

        public override void ToString()
        {
            Console.WriteLine("Bravo_1 - " + text2);
            Console.WriteLine("Bravo_2 - " + text3);
        }

    }






    #endregion

    #region Задача с наследованием, с использованием индексатора, с get, который возвращает длину строки.
    public class TextBase
    {
        private string _text;

        public TextBase(string text)
        {
            this._text = text;
        }

        public void ShowCon()
        {
            Console.WriteLine(_text);
        }

        public void SetText()
        {
            _text = "Захотел и присвоил";
        }

        public new void SetText(string text)
        {
            _text = text;
        }

        public int Length
        {
            get { return _text.Length; }
        }

        public int this[int indexChar]
        {
            get
            {
                return this[indexChar];
            }
        }
    }

    public class Text : TextBase
    {
        public int number;
        public Text(string text, int number) : base(text)
        {
            this.number = number;
        }

        public new void SetText()
        {
            base.SetText();
            number = 0;
        }

        public new void SetText(string text)
        {
            base.SetText(text);
            number = text.Length;
            Console.WriteLine("Длина текста = " + number);
        }

        public void SetText(int number)
        {
            this.number = number;
        }

        public void SetText(string text, int number)
        {
            base.SetText(text);
            this.number = number;

        }
    }

    #endregion

    #region Задача с массивом
    public class BaseArray
    {
        public int[] array;

        public BaseArray(int[] array)
        {
            this.array = array;
        }

        public void ToString()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
            Console.WriteLine();
        }
    }

    public class SonOfBaseArray : BaseArray
    {
        public char[] charArray;
        public SonOfBaseArray(int[] array, char[] charArray) : base(array)
        {
            this.charArray = charArray;
        }

        public new void ToString()
        {
            Console.WriteLine();
            base.ToString();
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + charArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }



    #endregion

    #region Цепочка наследования
    public class LinkBase
    {
        public int number;

        public LinkBase(int number)
        {
            this.number = number;
        }

        public void SetNumber(int number)
        {
            this.number = number;
        }

        public void Write()
        {
            Console.WriteLine("LinkBase: число " + number + ".");
        }
    }

    public class FirstLink : LinkBase
    {
        public char symbol;
        public FirstLink(int number, char symbol) : base(number)
        {
            this.symbol = symbol;
        }

        public void SetNumber(int number, char symbol)
        {
            this.symbol = symbol;
        }

        public new void Write()
        {
            Console.WriteLine("FirstLink: число " + number + "," + symbol + ".");
        }
    }

    public class SecondLink : FirstLink
    {
        public string text;
        public SecondLink(int number, char symbol, string text) : base(number, symbol)
        {
            base.number = number;
            this.text = text;
        }

        public void SetNumber(int number, char symbol, string text)
        {
            base.number = number;
            base.symbol = symbol;
            this.text = text;
        }

        public new void Write()
        {
            Console.WriteLine("FirstLink: число " + number + "," + symbol + "," + text + ".");
        }
    }

    #endregion

    #region Цепочка с object

    public class ObjectBase
    {
        public char symbol;

        public ObjectBase(char symbol)
        {
            this.symbol = symbol;
        }

        public ObjectBase(ObjectBase objectBase)
        {
            symbol = objectBase.symbol;
        }


        public void Show()
        {
            Console.Write(symbol);
        }
    }

    public class FirstObject : ObjectBase
    {
        public string text;
        public FirstObject(char symbol, string text) : base(symbol)
        {
            this.text = text;
        }

        public FirstObject(FirstObject firstObject) : base(firstObject)
        {
            text = firstObject.text;
        }

        public new void Show()
        {
            base.Show();
            Console.Write(text);
        }

    }

    public class SecondObject : FirstObject
    {
        public int number;
        public SecondObject(char symbol, string text, int number) : base(symbol, text)
        {
            this.number = number;
        }

        public SecondObject(SecondObject secondObject) : base(secondObject)
        {
            number = secondObject.number;
        }

        public new void Show()
        {
            base.Show();
            Console.Write(number);
        }

    }
    #endregion




    #endregion

    #region Бинарное представление числа
    public class Class13
    {
        private int num;
        public string s;

        public Class13(int num)
        {
            this.num = num;
        }

        public string this[int i]
        {
            get { return Convert.ToString(num, 2); }
        }
    }

    #endregion

    #region Индексация массива
    public class Class12
    {
        /*
          Class12 class12 = new Class12(5);
          class12[3] = 1;
          class12[1] = 2;
          Console.WriteLine(class12[0]);*/


        private int[] num;

        public Class12(int rangeArray)
        {
            num = new int[rangeArray];
        }

        public int this[int i]
        {
            get { return num[i]; }
            set { num[i] = value; }
        }
    }
    #endregion

    #region Сумма квадратов 
    public class SquaresSum
    {
        public static int sum = 0;
        public static void WriteCon()
        {
            Console.WriteLine("Введите число для нахождения суммы квадратов");
            int number = Convert.ToInt32(Console.ReadLine());
            SumSquares(number);
        }

        public static void SumSquares(int value)
        {
            if (value == 1)
            {
                sum += value;
                Console.WriteLine(sum);
            }
            if (value > 1)
            {
                double temp = Math.Pow(value, 2);
                sum += Convert.ToInt32(temp);
                SumSquares(value - 1);
            }
        }
    }
    #endregion

    #region Двойной факториал
    public class DoubleFactorial
    {
        public static int sum = 1;
        private static void WriteCon()
        {
            Console.WriteLine("Введите число для получения факториала");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                FacrorialEven(number);
            }
            else FacrorialOdd(number);
        }
        public static void FacrorialEven(int value)
        {

            if (value == 1)
            {
                sum *= value;
                Console.WriteLine("Ответ: " + sum);
            }
            if (value > 1)
            {
                int temp = value * 1;
                if (temp % 2 == 0)
                {
                    sum *= temp;
                    FacrorialEven(value - 1);
                }
                else FacrorialEven(value - 1);
            }
        }

        public static void FacrorialOdd(int value)
        {

            if (value == 1)
            {
                sum *= value;
                Console.WriteLine("Ответ: " + sum);
            }
            if (value > 1)
            {
                int temp = value * 1;
                if (temp % 2 == 1)
                {
                    sum *= temp;
                    FacrorialOdd(value - 1);
                }
                else FacrorialOdd(value - 1);
            }

        }
    }
    #endregion

    #region Факториал
    public class Factorial
    {
        public static int sum = 1;
        private static void WriteCon()
        {
            Console.WriteLine("Введите число для получения факториала");
            int number = Convert.ToInt32(Console.ReadLine());
            Facrorial(number);
        }

        public static void Facrorial(int value)
        {

            if (value == 1)
            {
                sum *= value;
                Console.WriteLine("Ответ: " + sum);
            }
            if (value > 1)
            {
                int temp = value * 1;
                sum *= temp;
                Facrorial(value - 1);
            }

        }
    }
    #endregion

    #region Конструктор
    public class TaskClass
    {
        private int a;
        private int b;

        public TaskClass()
        {
            a = 1;
            b = 2;
        }

        public TaskClass(int a)
        {
            this.a = a;
            b = 3;
        }

        public TaskClass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Show()
        {
            Console.WriteLine($"a: {a}, b: {b}");
        }
    }
    #endregion

    #region Получение символа из цифры 
    public class TaskClass2
    {
        public char A = 'A';
        public char D = 'Z';

        public void BetweenChar()
        {
            for (int i = 'A'; i < 'Z' + 1; i++)
            {
                Console.WriteLine(Convert.ToChar(i));
            }
        }
    }
    #endregion

    #region Преобразование вещ.числа в символ
    public class TaskClass3
    {
        public int number;
        public char b;

        public TaskClass3(double value)
        {
            string temps = Convert.ToString(value);
            int index = temps.IndexOf(',');
            if (index != -1)
            {
                number = Convert.ToInt32(temps.Substring(index + 1));
            }

            int temp = Convert.ToInt32(value / 1);
            b = Convert.ToChar(temp);

        }

        public void WriteCon()
        {
            Console.WriteLine("Введите вещественное число");
            double value = Convert.ToDouble(Console.ReadLine());
            TaskClass3 c = new TaskClass3(value);
            c.ShowCon();
        }

        public void ShowCon()
        {

            Console.WriteLine($"Остаток от введенного числа: {number}, целое число соответствует символу: {b}");
        }
    }
    #endregion // п

    #region Нахождение мин и макс с использованием params
    public class MinMaxAverageParams
    {
        private int maxNumber;
        private int minNumber;
        private int averageNumbers;
        private int sum;
        public void GiveMeNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Array.Sort(numbers);
                minNumber = numbers[0];
                maxNumber = numbers[numbers.Length - 1];

                sum = +numbers[i];
            }
            averageNumbers = sum / numbers.Length;
        }

        public void ShowCon()
        {
            Console.WriteLine("Наибольшее число: " + maxNumber);
            Console.WriteLine("Наименьшнее число: " + minNumber);
            Console.WriteLine("Среднее число: " + averageNumbers);
        }

        public void InsertMeInMain()
        {
            MinMaxAverageParams t = new MinMaxAverageParams();
            Console.WriteLine("Введите числа для нахождения наибольшего, наименьшего и среднего чисел");
            string input = Console.ReadLine();
            string[] m_string = input.Split(' ');
            int[] ints = new int[m_string.Length];
            for (int i = 0; i < m_string.Length; i++)
            {
                ints[i] = Convert.ToInt32(m_string[i]);
            }
            t.GiveMeNumbers(ints);
            t.ShowCon();
        }

    }
    #endregion

    #region Нахождение косинуса

    public class TaskClass5
    {
        private int a;
        private int b;
        private int c;
        private double cos;
        public void ConsolWrite()
        {
            Console.WriteLine("Здравствуйте, для нахождения косисуна, пожалуйста, введите данные.");
            Console.WriteLine("Введите длину наибольшей стороны треугольника: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину средней стороны треугольника: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длины наименьшей стороны треугольника: ");
            b = Convert.ToInt32(Console.ReadLine());


            cos = (Math.Pow(c, 2) - Math.Pow(a, 2) - Math.Pow(b, 2)) / (-2 * a * b);
        }

        public void ShowResult()
        {
            Console.WriteLine("Косинус равняется: " + cos);
        }
    }

    #endregion

    #region Дискриминант

    public class TaskClass6
    {
        public int a;
        public int b;
        public int c;

        public void ConsolWrite()
        {
            Console.WriteLine("Если уравнение выглядит так ax^2 + bx + c = 0, то заполните данные.");
            Console.WriteLine("Введите значение а.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b.");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение c.");
            c = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowResult()
        {

            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                double Res1 = (-b + Math.Sqrt(D)) / 2 * a;
                double Res2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine($"x_1 = {Res1}.");
                Console.WriteLine($"x_2 = {Res2}.");
            }
            if (D == 0)
            {
                double Res1 = -b / 2 * a;
                Console.WriteLine($"x = {Res1}.");
            }
            else Console.WriteLine("Нет решения.");

        }

    }
    #endregion

    #region Определение вхождения символа в заданный диапазон
    public class TaskClass7
    {
        private char symbol;



        public void GiveMeChar(char value)
        {
            Symbol = value;
        }

        private char Symbol
        {
            get { return symbol; }
            set
            {
                if (value >= 'A' && value <= 'Z')
                {
                    symbol = value;
                    Console.WriteLine("Данный символ входит в диапазон. Ваш символ:" + Symbol);
                }
                else
                {
                    Console.WriteLine("Данный символ выходит за границы диапазона.");
                }

            }
        }

    }
    #endregion

    #region Получение элемента из массива и использование инициализотора

    public class CLass8
    {
        private int[] numbers = new int[5] { 0, 1, 2, 3, 4 };
        private int indx;
        private int _index;

        public void GetIndex()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public void SetIndex(int value, int ind)
        {
            indx = ind;
            Number = value;
        }

        private int Number
        {
            get
            {
                return numbers[_index];
            }
            set
            {
                numbers[indx] = value;
                Console.WriteLine();
                Console.WriteLine(numbers[_index]);
                Console.WriteLine();
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }


    }
    #endregion

    #region Задача с get 
    public class Class9
    {
        private int[] numbers = new int[] { 0, 1, 4 };
        private int _sum;

        public void Show()
        {
            Console.WriteLine(Sum);
        }
        public int Sum
        {
            get
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    _sum += numbers[i];
                }
                return _sum;
            }
        }
    }
    #endregion

    #region Задача с set, преобразрование числа в символ
    public class Class10
    {
        private int _number;
        private char _char;

        public int Number
        {
            set
            {
                _number = value;
                _char = Convert.ToChar(_number);
                Console.WriteLine(_char);
            }
        }
        public void NumberToString(int value)
        {
            if (value < 0)
            {
                Console.WriteLine("Число не может быть меньше нуля.");
            }
            else
                Number = value;
        }
    }
    #endregion

    #region Задача с get и set, вывод нечетный чисел и присвоение им индекса
    public class Class11
    {
        private int _number;
        private int indexNumber;
        private int temp;
        public int Number
        {
            get
            {
                return _number;
            }
            set { _number = value; }
        }


        public void AddToNumber(int range)
        {
            for (int i = 0; i < range; i++)
            {
                if (Number % 2 == 0 || temp == Number)
                {
                    Number++;
                    indexNumber++;
                    temp = Number;
                    Console.WriteLine("Номер нечетного числа: " + indexNumber);
                    Console.WriteLine(Number);
                }
                if (temp == Number)
                {
                    Number++;
                }
            }
        }
    }
    #endregion
}
