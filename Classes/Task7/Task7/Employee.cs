using System;

namespace Task7
{
    enum Position
    {
        Junior, Middle, Senior
    }
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Position Position { get; set; }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void CalculateSalary()
        {
            if (Position == Position.Junior)
                Console.WriteLine($"{Name} {Surname}\nPosition: {Position}\nTax = 0%\nSlary = 10000");
            else if (Position == Position.Middle)
                Console.WriteLine($"{Name} {Surname}\nPosition: {Position}\nTax = {20000 * 0.1}(10%)\nSlary = 20000");
            else
                Console.WriteLine($"{Name} {Surname}\nPosition: {Position}\nTax = {30000 * 0.2}(20%)\nSlary = 30000");
        }
    }
}
