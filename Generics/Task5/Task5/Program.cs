using System;

namespace Task5
{
    internal class Program
    {
        private static void Main()
        {
            var car = new CarCollection<string, int>(2, new Tuple<string, int>("BMW", 2020), new Tuple<string, int>("Tesla", 2010));

            car.Add("Audi", 2020);

            Console.WriteLine("Before deleting:\n");

            for (var i = 0; i < car.Size; i++)
            {
                Console.WriteLine(car[i].Item1 + " - " + car[i].Item2);
            }

            car.DeleteAll();

            car.Add("Honda", 2015);

            Console.WriteLine("\nAfter deleting and adding new element:");

            for (var i = 0; i < car.Size; i++)
            {
                Console.WriteLine(car[i].Item1 + " - " + car[i].Item2);
            }
            Console.ReadKey();
        }
    }
}
