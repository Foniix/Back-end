using System;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Play\n2.Record\n0.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        player.Play();
                        Thread.Sleep(1000);
                        ((IPayable)player).Pause();
                        ((IPayable)player).Stop();
                        Console.ReadKey();
                        break;
                    case 2:
                        player.Record();
                        Thread.Sleep(1000);
                        ((IRecodable)player).Pause();
                        ((IRecodable)player).Stop();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Goodbye!");
                        break;
                }
            } while (choice !=0);
            player.Play();
        }
    }
}
