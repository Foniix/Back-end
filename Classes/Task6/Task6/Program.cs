using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(23.5, 26.5, 2.68);
            int value;
            do
            {
                Console.Clear();
                Console.WriteLine("\nTask #6(_Converter_)");
                Console.WriteLine("1 - USD");
                Console.WriteLine("2 - EUR");
                Console.WriteLine("3 - RUB");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("Pick value");
                value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.WriteLine("Enter value (UAH)...");
                        converter.Uah = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"USD:{converter.Uah / converter.usd}");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Enter value (UAH)...");
                        converter.Uah = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"EUR:{converter.Uah / converter.eur}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Enter value (UAH)...");
                        converter.Uah = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"RUB:{converter.Uah * converter.rub}");
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("thx.");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (value != 0);
            Console.WriteLine("/////////////////////////////////////////////////////////");

        }
    }
}
