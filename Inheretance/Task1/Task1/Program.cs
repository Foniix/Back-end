using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer print = new GreenPrint(ConsoleColor.Yellow);
            print.Print("Yellow");
            Console.ResetColor();
        }
    }
}
