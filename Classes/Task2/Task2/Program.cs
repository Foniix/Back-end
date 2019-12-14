using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task #2(_Rectangel_)");
            Console.WriteLine("Enter firts side:");
            double mySide1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second side:");
            double mySide2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(mySide1, mySide2);
            Console.WriteLine($"Area:{rectangle.Area()}\nPerimeter:{rectangle.Perimetr()}");
            Console.WriteLine("/////////////////////////////////////////////////////////");

        }
    }
}
