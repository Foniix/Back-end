using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    static class MyPrint
    {
        public static void Print(string stroka, int color)
        {
            var colors = (Colors) color;
            switch (colors)
            {
                case Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(stroka);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
