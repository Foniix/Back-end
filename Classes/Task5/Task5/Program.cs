using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask #5(_User_)");
            User user = new User();
            Console.WriteLine("Enter Login:");
            user.Login = Console.ReadLine();
            Console.WriteLine("Enter Name:");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Surname:");
            user.LastName = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            user.Age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(user);
            Console.WriteLine("/////////////////////////////////////////////////////////");

        }
    }
}
