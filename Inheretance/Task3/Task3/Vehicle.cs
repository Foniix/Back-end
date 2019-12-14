using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Vehicle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }
        public int ReleaseYear { get; set; }

        public virtual void Show()
        {
            Console.Write($"Координаты - х: {X} у: {Y}\nЦена - {Price}$\nСкорость - {Speed}km\\h\nГод выпуска - {ReleaseYear}");
        }

        public Vehicle()
        {
            X = 0;
            Y = 0;
            Price = 0;
            Speed = 0;
            ReleaseYear = 0;
        }

        public Vehicle(int x, int y, double price, double speed, int release)
        {
            this.X = x;
            this.Y = y;
            this.Price = price;
            this.Speed = speed;
            this.ReleaseYear = release;
        }

    }
}
