using System;

namespace Task_3_and_6
{
    internal class Program
    {
        private static void Main()
        {
            var dic = new MyDictionary<int, string>();
            dic.Add(0, "Dog");
            dic.Add(1, "Cat");
            for (var i = 0; i < dic.Length; i++)
                Console.WriteLine(i.ToString() + ' ' + dic[i]);
            Console.ReadKey();
        }
    }
}
