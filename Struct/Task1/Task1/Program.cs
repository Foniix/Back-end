using System;

namespace Task1
{
    struct Notebook
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }

        public Notebook(string model, string manufacturer, int price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }

        public override string ToString()
        {
            return $"Model = {Model};\nManufacturer = {Manufacturer};\nPrice = {Price}$.\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var notebook = new Notebook("MacBook", "Pro", 5000);

            Console.WriteLine(notebook.ToString());

            Console.ReadLine();
        }
    }
}
