using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|Car|");
            Car car = new Car(123, 231, 5000, 10, 2007);
            car.Show();
            Console.WriteLine("\n|Ship|");
            Ship ship = new Ship(4234, 123, 400000, 3.3, 2009, "Odessa", 100);
            ship.Show();
            Console.WriteLine("\n|Plane|");
            Plane plane = new Plane(123, 53, 10000, 100, 2019, 1, 4);
            plane.Show();
        }
    }
}
