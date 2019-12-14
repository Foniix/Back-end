using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Ship : Vehicle
    {
        public int NumberPassengers { get; set; }
        public string HomePort { get; set; }
        public Ship() : base()
        {
            NumberPassengers = 0;
            HomePort = "";
        }
        public Ship(int x, int y, double price, double speed, int release, string port, int num) : base(x, y, price, speed, release)
        {
            HomePort = port;
            NumberPassengers = num;
        }
        public override void Show()
        {
            base.Show();
            Console.Write($"\nКоличество пассажиров - {NumberPassengers}\nПорт приписки - {HomePort}");
        }
    }
}
