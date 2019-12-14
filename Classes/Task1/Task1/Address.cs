using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Address
    {
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public int Apartment { get; set; }

        public override string ToString()
        {
            return $"Index: {Index}\n" +
                   $"Country: {Country}\n" +
                   $"City: {City}\n" +
                   $"Street: {Street}\n" +
                   $"House: {House}\n" +
                   $"Apatment: {Apartment}\n";

        }
    }
}
