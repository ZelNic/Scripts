
namespace Tasks_of_the_Second_Book.Chapter_2
{
    delegate char MyDelegate3();

    internal class Task3
    {
        private string _text;
        private MyDelegate3 _delegate3;

        public MyDelegate3 Delegate
        {
            get { return _delegate3; }
        }

        public Task3(string text, bool value)
        {
            _text = text;
            if (value == true)
            {
                _delegate3 = delegate
                {
                    System.Console.WriteLine(_text[_text.Length - 1]);
                    return _text[_text.Length - 1];
                };

            }
            else
            {
                _delegate3 = delegate
                {
                    System.Console.WriteLine(_text[0]);
                    return _text[0];
                };
            }
        }
    }
}
