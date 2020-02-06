using System;

namespace Task2
{
    internal class Program
    { 
        private static void Main(string[] args)
        {
            static double Add(int x, int y) => x + y;
            static double Sub(int x, int y) => x - y;
            static double Mul(int x, int y) => x * y;

            static double Div(int x, int y)
            {
                if (y != 0) return (x / y);
                Console.WriteLine("Error! Деление на ноль!");
                return 0;
            }

            while (true)
            {
                Console.WriteLine("Введите через пробел два числа. Для выхода введите 'Exit'");
                var readOp = Console.ReadLine();
                if (readOp == "Exit") break;
                try
                {
                    var read = readOp.Split();
                    var input1 = Convert.ToInt32(read[0]); var input2 = Convert.ToInt32(read[1]);
                    Console.WriteLine("Введите операцию(+, -, *, /.)");
                    readOp = Console.ReadLine();
                    switch (readOp)
                    {
                        case "/":
                            {
                                Console.WriteLine("Результат: " + Div(input1, input2));
                                break;
                            }
                        case "*":
                            {
                                Console.WriteLine("Результат: " + Mul(input1, input2));
                                break;
                            }
                        case "+":
                            {
                                Console.WriteLine("Результат: " + Add(input1, input2));
                                break;
                            }
                        case "-":
                            {
                                Console.WriteLine("Результат: " + Sub(input1, input2));
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Невверный ввод!");
                                break;
                            }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода!");
                }
            }
        }
    }
}
