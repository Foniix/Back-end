using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Plane : Vehicle
    {
        public double FlightAltitude { get; set; }
        public int NumberPassengers { get; set; }
        public Plane() : base()
        {
            FlightAltitude = 0;
            NumberPassengers = 0;
        }
        public Plane(int x, int y, double price, double speed, int release, double attitude, int num) : base(x, y, price, speed, release)
        {
            FlightAltitude = attitude;
            NumberPassengers = num;
        }
        public override void Show()
        {
            base.Show();
            Console.Write($"\nВысота - {FlightAltitude}km\nКоличество пассажиров - {NumberPassengers}");
        }
    }
}
