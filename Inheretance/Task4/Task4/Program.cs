using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string key;
            Console.Write("Введите ключь для доступап к версии Pro или Expert: ");
            key = Console.ReadLine();
            if (key.Equals(new ProDocumentWorker().Key))
            {
                Console.WriteLine("Вы используете версию Pro!");
                _ = new ProDocumentWorker();
            }
            else if (key.Equals(new ExpertDocumentWorker().Key))
            {
                Console.WriteLine("Вы используете версию Expert!");
                _ = new ExpertDocumentWorker();
            }
            else
            {
                Console.WriteLine("Вы используете версию Free!");
                _ = new DocumentWorker();
            }
            Console.ReadKey();
        }
    }
}
