using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address()
            {
                Index = 49000,
                Country = "Ukraine",
                City = "Dnepr",
                Street = "Korolenko",
                House = "4A",
                Apartment = 45
            };

            Console.WriteLine("Task #1(_Address_)\n" + address);
            Console.WriteLine("\n/////////////////////////////////////////////////////////");
        }
    }
}
