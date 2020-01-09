using System;

namespace Task5
{
    enum Colors
    {
        Red = 1,
        Blue,
        Green,
        Magenta,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            var input = Console.ReadLine();
            Console.WriteLine("Chosen color 1-Red, 2-Blue, 3-Green, 4-Magneta");
            var numOfColor = Convert.ToInt32(Console.ReadLine());
            if (numOfColor < 1 || numOfColor > 8) { Console.WriteLine("Wrong input!"); }
            else
            {
                Console.WriteLine("Result: ");
                MyPrint.Print(input, numOfColor);
            }
            Console.ReadKey();
        }
    }
}
