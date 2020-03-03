using System;

namespace Task2
{
    internal class Program
    {
        private static void Main()
        {
            var list = new MyList<int>(10, 1,2,3,4,5,6,7,8,9,10);
            Console.WriteLine("List creating:");
            for (var i = 0; i < list.Size; i++)
            {
                Console.Write(list[i] + " ");
            }

            list.Add(11);

            Console.WriteLine("\nAdded new elements:");
            for (var i = 0; i < list.Size; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine("\nSize = " + list.Size);

            Console.WriteLine("Task4:");
            var arr = list.GetArray();

            foreach (var t in arr)
            {
                Console.Write(t + " ");
            }
            Console.ReadKey();
        }
    }
}
