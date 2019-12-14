using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask #4(_Figure/Point_)");
            Point a = new Point(30, 7);
            Point b = new Point(2, 9);
            Point c = new Point(49, 2);
            Point d = new Point(1, 23);
            Point e = new Point(5, 3);
            figure figure = new figure(a, b, c, d, e);
            figure.Name = "Fives";
            Console.WriteLine(figure.Name + "\nPerimetr: " + figure.CalculatePerimeter());
            Console.WriteLine("/////////////////////////////////////////////////////////");

        }
    }
}
