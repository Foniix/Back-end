using System;

namespace Task6
{
    enum Position
    {
        Junior = 10, 
        Middle = 20, 
        Senior = 40
    }
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant acc = new Accauntant();
            var senior = Position.Senior;
            Console.WriteLine(acc.AskForBonus(senior, 50) ? "Take premium" : "Don`t take premium");
            Console.ReadKey();
        }
    }
}
