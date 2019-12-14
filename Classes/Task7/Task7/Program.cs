using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask #7(_Employee_)");
            Employee employee = new Employee("Ivan", "Petrov")
            {
                Position = Position.Middle
            };
            employee.CalculateSalary();
            Console.WriteLine("/////////////////////////////////////////////////////////");

        }
    }
}
