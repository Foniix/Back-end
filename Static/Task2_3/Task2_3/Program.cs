using System;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[20];
            var rnd = new Random();
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0,100);
            }
            Console.WriteLine("Массив перед сортировкой:");
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("По возрастани - 0,\nПо убыванию - 1.");
            var value = Console.ReadLine();
            if (value == "0")
            {
                arr.SortByBool(0, arr.Length - 1, true);
                foreach (var a in arr)
                {
                    Console.WriteLine(a);
                }
            }
            if (value == "1")
            {
                arr.SortByBool(0, arr.Length - 1, false);
                foreach (var a in arr)
                {
                    Console.WriteLine(a);
                }
            }
            else
                Console.WriteLine("Error value!");

            Console.ReadKey();
        }
    }
}
