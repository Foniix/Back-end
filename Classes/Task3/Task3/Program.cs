using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask #3(_Book_)");
            Console.WriteLine("Enter title...");
            string title = Console.ReadLine();
            Console.WriteLine("Enter author...");
            string author = Console.ReadLine();
            Console.WriteLine("Enter content...");
            string content = Console.ReadLine();
            Book book = new Book(title, author, content);
            book.Show();
            Console.ResetColor();
            Console.WriteLine("/////////////////////////////////////////////////////////");

        }
    }
}
