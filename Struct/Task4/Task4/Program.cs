using System;

namespace Task4
{
    class Program
    {
        struct BirthDay
        {
            public int Day { get; set; }
            public int Year { get; set; }
            public int Month { get; set; }
        }

        static void BirthdayCalculator()
        {
            var birthDay = new BirthDay();
            Console.WriteLine("Enter your Birthday:");
            Console.WriteLine("Day");
            birthDay.Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month");
            birthDay.Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year");
            birthDay.Year = Convert.ToInt32(Console.ReadLine());
            
            try
            {
                var date = new DateTime(birthDay.Year, birthDay.Month, birthDay.Day);
                var ng = new DateTime(DateTime.Now.Year, 12, 31);
                var remainDay = date.DayOfYear - DateTime.Now.DayOfYear;
                if (date.Year > DateTime.Now.Year)
                    throw new Exception();
                else if (remainDay < 0)
                {
                    remainDay = ng.DayOfYear - DateTime.Now.DayOfYear + date.DayOfYear;
                }
                Console.WriteLine($"До вашего дня рождения осталось {remainDay} дней!");
            }
            catch
            {
                Console.WriteLine("Error input value! Try again!");
                BirthdayCalculator();
            }
        }

        static void Main(string[] args)
        {
            BirthdayCalculator();
            Console.ReadLine();
        }
    }
}
