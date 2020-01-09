using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            var op = "";

            do
            {
                Console.WriteLine("\\Нажмите на Enter/");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Введите первое число:");
                var a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите операцию (+-/*):");
                op = Console.ReadLine();

                Console.WriteLine("Введите второе число:");
                var b = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                switch (op)
                {
                    case "+":
                        result = Calculator.Add(a, b);
                        Console.WriteLine($"Результат: {a} {op} {b} = {result}");
                        break;
                    case "-":
                        result = Calculator.Sub(a, b);
                        Console.WriteLine($"Результат: {a} {op} {b} = {result}");
                        break;
                    case "/":
                        result = Calculator.Div(a, b);
                        Console.WriteLine($"Результат: {a} {op} {b} = {result}");
                        break;
                    case "*":
                        result = Calculator.Mul(a, b);
                        Console.WriteLine($"Результат: {a} {op} {b} = {result}");
                        break;
                    case "0":
                        Console.WriteLine( "BB");
                        break;
                    default:
                        Console.WriteLine("Введите корректный символ!");
                        Console.Read();
                        break;
                }
            } while (op != "0");
            
        }
    }
}
