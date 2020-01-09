using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        { 
            string str = "Hello from Miami!";
            Console.WriteLine(str.MySubstring(2, 7));
            Console.WriteLine(str.MyIndexOf("from"));
            Console.WriteLine(str.MyReplace("i", "O"));

            Console.ReadKey();
        }
    }
}
