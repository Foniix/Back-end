using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Car : Vehicle
    {
        public Car() : base() { }
        public Car(int x, int y, double price, double speed, int release) : base(x, y, price, speed, release) { }
    }
}
