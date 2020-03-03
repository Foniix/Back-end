using System;

namespace Task7
{
    internal class Program
    {
        private static void Main()
        {
            var arrayList = new ArrayList(new object[] { "Hi From", ' ', 2020, ' ', 'D','N','E','P','R' });
            Console.WriteLine("ArrayList after creating:");

            for (var i = 0; i < arrayList.Size; i++)
            {
                Console.Write(arrayList[i]);
            }

            arrayList.Clear();
            arrayList.AddRange(new object[] { 'H', 'i', ' ', 2000, ' ', "With Love" });
            Console.WriteLine("\nArrayList after clearing and added range:");

            for (var i = 0; i < arrayList.Size; i++)
            {
                Console.Write(arrayList[i]);
            }

            arrayList.Remove(1);
            Console.WriteLine("\nAfter removing element with index 1:");
            for (var i = 0; i < arrayList.Size; i++)
            {
                Console.Write(arrayList[i]);
            }

            arrayList.Reverse();
            Console.WriteLine("\nAfter reversing:");
            for (var i = 0; i < arrayList.Size; i++)
            {
                Console.Write(arrayList[i]);
            }

            Console.ReadKey();
        }
    }
}
