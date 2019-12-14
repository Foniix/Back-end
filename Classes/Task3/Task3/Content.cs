using System;

namespace Task3
{
    class Content
    {
        public string content;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(content);
        }
    }
}
