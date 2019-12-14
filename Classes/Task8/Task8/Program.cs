using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask #8(_Invoice_)");
            Invoice inv = new Invoice(2, "Ivan Petrov", "TSK", 1000)
            {
                Article = "pencil",
                Quantity = 2
            };
            Console.WriteLine(inv.ToString());
        }
    }
}
