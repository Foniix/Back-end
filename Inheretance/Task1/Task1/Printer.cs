using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Printer
    {
        protected ConsoleColor Color;
        public Printer(ConsoleColor color)
        {
            Color = color;
        }
        public virtual void Print(string value)
        {
            Console.ForegroundColor = this.Color;
            Console.WriteLine(value);
        }   
    }
}
